using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectrometrBasic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] comPorts = System.IO.Ports.SerialPort.GetPortNames();

            while (comPorts.Length == 0)
            {
                DialogResult result = MessageBox.Show("No COM ports in system!", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                    comPorts = System.IO.Ports.SerialPort.GetPortNames();
                else
                    break;
            }

            if (comPorts.Length > 0)
                Application.Run(new Form1(comPorts));
        }
    }
}
