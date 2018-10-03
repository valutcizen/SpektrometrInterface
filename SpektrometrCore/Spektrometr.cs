using System;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SpektrometrCore
{
    public class Spektrometr : IDisposable
    {
        public void SetPortyIO(byte value) => WriteByte(9, value);
        public void SetUstawionyKatLusterko(byte value) => WriteByte(10, value);
        public void SetUstawioneImpulsy1(Int32 value) => WriteInt32(11, value);
        public void SetUstawioneImpulsy2(Int32 value) => WriteInt32(15, value);
        public void SetPredkoscMax1(byte value) => WriteByte(19, value);
        public void SetPredkoscMax2(byte value) => WriteByte(20, value);
        public void SetPredkosciMax(byte[] predkosci) => WriteBytes(19, predkosci);

        public static bool IsPozycjonowanie1(byte status) => 0 != (status & (1 << 0));
        public static bool IsPozycjonowanie2(byte status) => 0 != (status & (1 << 1));
        public static bool IsJazdaLewo1(byte status) => 0 != (status & (1 << 2));
        public static bool IsJazdaPrawo1(byte status) => 0 != (status & (1 << 3));
        public static bool IsJazdaLewo2(byte status) => 0 != (status & (1 << 4));
        public static bool IsJazdaPrawo2(byte status) => 0 != (status & (1 << 5));

        SerialPort serialPort;
        TimeSpan timeout;

        public Spektrometr(string serialPortName, int communicationTimeout) : this(serialPortName, 115200, communicationTimeout)
        {
        }

        public Spektrometr(string serialPortName, int bitrate, int communicationTimeout)
        {
            serialPort = new SerialPort(serialPortName, bitrate);
            serialPort.ReadTimeout = communicationTimeout;
            serialPort.Open();
            timeout = new TimeSpan(0, 0, 0, 0, communicationTimeout);
        }

        private bool WriteByte(byte addr, byte value)
        {
            byte[] command = Sptpp.WriteCommand(new byte[] { value }, addr);
            serialPort.Write(command, 0, command.Length);
            return Sptpp.GetWriteResponse(serialPort) == 1;
        }

        private bool WriteBytes(byte addr, byte[] value)
        {
            byte[] command = Sptpp.WriteCommand(value, addr);
            serialPort.Write(command, 0, command.Length);
            return Sptpp.GetWriteResponse(serialPort) == value.Length;
        }

        private bool WriteInt16(byte addr, Int16 value)
        {
            byte[] command = Sptpp.WriteCommand(BitConverter.GetBytes(value), addr);
            serialPort.Write(command, 0, command.Length);
            return Sptpp.GetWriteResponse(serialPort) == 2;
        }

        private bool WriteUInt16(byte addr, UInt16 value)
        {
            byte[] command = Sptpp.WriteCommand(BitConverter.GetBytes(value), addr);
            serialPort.Write(command, 0, command.Length);
            return Sptpp.GetWriteResponse(serialPort) == 2;
        }

        private bool WriteInt32(byte addr, Int32 value)
        {
            byte[] command = Sptpp.WriteCommand(BitConverter.GetBytes(value), addr);
            serialPort.Write(command, 0, command.Length);
            return Sptpp.GetWriteResponse(serialPort) == 4;
        }

        public SpektrometrStatus GetAllVariables()
        {
            byte[] command = Sptpp.ReadCommand(0, 10);
            serialPort.Write(command, 0, command.Length);
            byte[] response = Sptpp.GetReadResponse(serialPort, 10);

            if (response == null || response.Count() < 6)
            {
                serialPort.DiscardOutBuffer();
                serialPort.DiscardInBuffer();
                throw new FormatException();
            }

            byte status = response[0];
            byte port = response[9];

            return new SpektrometrStatus
            {
                MainStatus = status,
                IoStatus = port,
                Pozycjonowanie1 = IsPozycjonowanie1(status),
                Pozycjonowanie2 = IsPozycjonowanie2(status),
                JazdaLewo1 = IsJazdaLewo1(status),
                JazdaPrawo1 = IsJazdaPrawo1(status),
                JazdaLewo2 = IsJazdaLewo2(status),
                JazdaPrawo2 = IsJazdaPrawo2(status),
                Input1 = (port & (1 << 0)) != 0,
                Input2 = (port & (1 << 1)) != 0,
                Input3 = (port & (1 << 2)) != 0,
                Input4 = (port & (1 << 3)) != 0,
                AktualneImpulsy1 = BitConverter.ToInt32(response, 1),
                AktualneImpulsy2 = BitConverter.ToInt32(response, 5)
            };
        }

        public void Dispose()
        {
            serialPort?.Dispose();
        }
    }
}
