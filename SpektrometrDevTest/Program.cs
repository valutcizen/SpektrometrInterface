using SpektrometrCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpektrometrDevTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync();
            while (true) ;
        }

        async static void MainAsync()
        {
            try
            {
                int counter = 0;
                using (Spektrometr s = new Spektrometr("COM3", 1000))
                    while (true)
                    {
                        try
                        {
                            SpektrometrStatus status = await s.GetAllVariablesAsync();
                            Console.Clear();
                            Console.WriteLine($"Aktualna pozycja 1: { status.AktualneImpulsy1 }");
                            Console.WriteLine($"Aktualna pozycja 2: { status.AktualneImpulsy2 }");
                            Console.WriteLine($"Port 1: { status.Input1 }");
                            Console.WriteLine($"Port 2: { status.Input2 }");
                            Console.WriteLine($"Port 3: { status.Input3 }");
                            Console.WriteLine($"Port 4: { status.Input4 }");
                            Console.WriteLine($"Format Exceptions: { counter }");
                            await Task.Delay(100);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine($"{ e.Message }");
                            counter++;
                        }
                    }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
