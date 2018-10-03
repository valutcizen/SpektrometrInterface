using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace SpektrometrCore
{
    public static class Sptpp
    {
        static byte[] buffer = new byte[1024];

        public enum ResponseType { Unfinished, Readed, Writed, ReadError, WriteError };
        public class SptppResponse
        {
            public ResponseType ResponseType = ResponseType.Unfinished;
            public int index = 0;
            public byte size = 0;
            public byte[] ReadedBytes = null;
        }

        public static byte[] CalculateChecksum(byte[] data, int index, int count)
        {
            UInt16 sum1 = 0;
            UInt16 sum2 = 0;

            for (int i = index; i < index + count; ++i)
            {
                sum1 = (UInt16)((sum1 + data[i]) % 255);
                sum2 = (UInt16)((sum2 + sum1) % 255);
            }

            return new byte[] { (byte)sum1, (byte)sum2 };
        }

        public static byte[] CalculateChecksum(byte[] data, int count)
            => CalculateChecksum(data, 0, count);

        public static byte[] CalculateChecksum(byte[] data)
            => CalculateChecksum(data, 0, data.Length);

        public static byte[] WriteCommand(byte[] values, byte addr, byte size)
        {
            if (values.Length < size)
                throw new IndexOutOfRangeException("Values must have size at least of size");

            byte[] result = new byte[size + 5];

            result[0] = 0xF0;
            result[1] = addr;
            result[2] = size;

            for (int i = 0; i < size; i++)
                result[3 + i] = values[i];

            byte[] cs = CalculateChecksum(result, size + 3);
            result[size + 3] = cs[0];
            result[size + 4] = cs[1];

            return result;
        }

        public static byte[] WriteCommand(byte[] values, byte addr)
            => WriteCommand(values, addr, (byte)values.Length);

        public static byte[] ReadCommand(byte addr, byte size)
        {
            byte[] result = new byte[5];
            result[0] = 0xAA;
            result[1] = addr;
            result[2] = size;

            byte[] cs = CalculateChecksum(result, 3);
            result[3] = cs[0];
            result[4] = cs[1];

            return result;
        }

        public static SptppResponse GetResponse(byte[] receivedData, int bufSize)
        {
            if (receivedData == null)
                throw new ArgumentNullException(nameof(receivedData));

            for (int i0 = 0; i0 < bufSize - 4; i0++)
            {
                if (receivedData[i0] == 0x0F)
                {
                    if (receivedData[i0 + 1] == 0 && receivedData[i0 + 2] == 0x0F && receivedData[i0 + 3] == 0x0F)
                        return new SptppResponse() { ResponseType = ResponseType.WriteError, index = i0 };

                    byte[] cs = CalculateChecksum(receivedData, i0, 2);
                    if (cs[0] == receivedData[i0 + 2] && cs[1] == receivedData[i0 + 3])
                        return new SptppResponse() { ResponseType = ResponseType.Writed, size = receivedData[i0 + 1], index = i0 };
                }
                else if (receivedData[i0] == 0x55)
                {
                    byte size = receivedData[i0 + 1];

                    if (size == 0 && receivedData[i0 + 2] == 0x55 && receivedData[i0 + 3] == 0x55)
                        return new SptppResponse() { ResponseType = ResponseType.ReadError, index = i0 };

                    byte[] cs = CalculateChecksum(receivedData, i0, size + 2);
                    if (cs[0] == receivedData[i0 + size + 2] && cs[1] == receivedData[i0 + size + 3])
                    {
                        byte[] result = new byte[size];
                        Array.Copy(receivedData, i0 + 2, result, 0, size);
                        return new SptppResponse() { ResponseType = ResponseType.Readed, size = size, index = i0, ReadedBytes = result };
                    }
                }
            }
            return new SptppResponse();
        }

        public static async Task<int> GetWriteResponseAsync(Stream response, CancellationToken ct)
        {
            byte[] buf = new byte[4];
            int len = await response.ReadAsync(buf, 0, 4, ct);
            
            if (len == 4 && buf[0] == 0x0F)
            {
                byte[] cs = CalculateChecksum(buf, 0, 2);
                if (cs[0] == buf[2] && cs[1] == buf[3])
                    return buf[1];
            }
            return 0;
        }

        public static int GetWriteResponse(SerialPort serialPort)
        {
            byte[] buf = new byte[4];
            int len = 0;
            while (len < 4)
                len += serialPort.Read(buf, len, 4 - len);
            serialPort.DiscardInBuffer();

            if (buf[0] == 0x0F)
            {
                byte[] cs = CalculateChecksum(buf, 0, 2);
                if (cs[0] == buf[2] && cs[1] == buf[3])
                    return buf[1];
            }
            return 0;
        }

        public static byte[] GetReadResponse(SerialPort serialPort, int size)
        {
            byte[] buffer = new byte[size + 4];
            int len = 0;

            while (len < size + 4)
                len += serialPort.Read(buffer, len, size + 4 - len);
            serialPort.DiscardInBuffer();

            byte[] cs = CalculateChecksum(buffer, size + 2);
            if (cs[0] == buffer[size + 2] && cs[1] == buffer[size + 3])
            {
                byte[] response = new byte[size];
                Array.Copy(buffer, 2, response, 0, size);
                return response;
            }
            else
                throw new InvalidDataException($"Checksum not valid: { cs[0] } == { buffer[size + 2] } && { cs[1] } == { buffer[size + 3] } z { BitConverter.ToString(buffer, 0, size)}");
        }

        private static void ReadWithCancellationToken(SerialPort serialPort, ref int pos, int toPos, ref CancellationToken ct)
        {
            while (pos < toPos)
            {
                try
                {
                    Task<int> readSerialTask = serialPort.BaseStream.ReadAsync(buffer, pos, toPos - pos, ct);
                    readSerialTask.Wait(ct);
                    pos += readSerialTask.Result;
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }
        }
    }
}
