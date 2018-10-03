using SpektrometrCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpectrometrBasic
{
    public partial class Form1 : Form
    {
        Spektrometr spektrometr;
        Timer readTimer;
        object commLock = new object();
        byte lastIoStatus = 0;

        public Form1(string[] comPorts)
        {
            InitializeComponent();

            foreach (string portName in comPorts)
                PortChoose.Items.Add(portName);

            PortChoose.Text = comPorts[0];
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                int interval = Convert.ToInt32(RefreshRate.Value);
                spektrometr = new Spektrometr(PortChoose.Text, int.Parse(BitRate.Text), interval / 2);

                readTimer = new Timer();
                readTimer.Interval = interval;
                readTimer.Tick += ReadVariables;

                PortChoose.Enabled = false;
                BitRate.Enabled = false;
                RefreshRate.Enabled = false;
                Connect.Enabled = false;

                WyslijPorty.Enabled = true;
                WyslijVMax.Enabled = true;
                Wyslij1.Enabled = true;
                Przepisz1.Enabled = true;
                Wyslij2.Enabled = true;
                Przepisz2.Enabled = true;
                LusterkoWyslij.Enabled = true;
                Dissconnect.Enabled = true;

                ConnectionErrors.Value = 0;
                readTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured:{ Environment.NewLine }{ ex.ToString() }", "Unable to open port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dissconnect_Click(Connect, null);
            }
        }

        private void Dissconnect_Click(object sender, EventArgs e)
        {
            try
            {
                spektrometr.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured:{ Environment.NewLine }{ ex.ToString() }", "Unable to dispose port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                spektrometr = null;
            }

            try
            {
                readTimer.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured:{ Environment.NewLine }{ ex.ToString() }", "Timer Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                readTimer = null;
            }

            PortChoose.Enabled = true;
            BitRate.Enabled = true;
            RefreshRate.Enabled = true;
            Connect.Enabled = true;

            WyslijPorty.Enabled = false;
            WyslijVMax.Enabled = false;
            Wyslij1.Enabled = false;
            Przepisz1.Enabled = false;
            Wyslij2.Enabled = false;
            Przepisz2.Enabled = false;
            LusterkoWyslij.Enabled = false;
            Dissconnect.Enabled = false;
        }
        
        private void ReadVariables(object sender, EventArgs e)
        {
            SpektrometrStatus status;
            readTimer.Stop();

            try
            {
                lock (commLock)
                {
                    status = spektrometr.GetAllVariables();
                }
                Invoke(new Action(() => UpdateValues(status)));
            }
            catch (FormatException)
            {
                ConnectionErrors.Invoke(new Action(CountErrors));
            }
            catch (System.IO.InvalidDataException)
            {
                ConnectionErrors.Invoke(new Action(CountErrors));
            }
            readTimer.Start();
        }

        private void CountErrors()
        {
            ConnectionErrors.Value++;
        }

        private void UpdateValues(SpektrometrStatus status)
        {
            int mainStatus = status.MainStatus;
            for (int i = 0; i < 6; i++)
                StatusIndicator.SetItemCheckState(i, (mainStatus & (1 << i)) != 0 ? CheckState.Checked : CheckState.Unchecked);

            int ioStatus = status.IoStatus;
            for (int i = 0; i < 8; i++)
                IOStatus.SetItemCheckState(i, (ioStatus & (1 << i)) != 0 ? CheckState.Checked : CheckState.Unchecked);

            AktualneImpulsy1.Value = status.AktualneImpulsy1;
            AktualneImpulsy2.Value = status.AktualneImpulsy2;

            lastIoStatus = status.IoStatus;
        }

        private void WyslijPorty_Click(object sender, EventArgs e)
        {
            int ioOut = lastIoStatus;

            for (int i = 0; i < 4; i++)
            {
                if (Outputs.GetItemChecked(i))
                    ioOut |= (1 << (4 + i));
                else
                    ioOut &= ~(1 << (4 + i));
            }

            readTimer.Stop();
            try
            {
                lock (commLock)
                {
                    spektrometr.SetPortyIO((byte)ioOut);
                }
            }
            catch (TimeoutException)
            {
                ConnectionErrors.Invoke(new Action(CountErrors));
            }
            readTimer.Start();
        }

        private void WyslijVMax_Click(object sender, EventArgs e)
        {
            readTimer.Stop();
            try
            { 
                byte[] predkosci = new byte[]
                {
                    Convert.ToByte(VMax1.Value),
                    Convert.ToByte(VMax2.Value)
                };

                lock (commLock)
                {
                    spektrometr.SetPredkosciMax(predkosci);
                }
            }
            catch (TimeoutException)
            {
                ConnectionErrors.Invoke(new Action(CountErrors));
            }
            readTimer.Start();
        }

        private void Wyslij1_Click(object sender, EventArgs e)
        {
            readTimer.Stop();
            try
            { 
                lock (commLock)
                {
                    spektrometr.SetUstawioneImpulsy1(Convert.ToInt32(UstawioneImpulsy1.Value));
                }
            }
            catch (TimeoutException)
            {
                ConnectionErrors.Invoke(new Action(CountErrors));
            }
            readTimer.Start();
        }

        private void Wyslij2_Click(object sender, EventArgs e)
        {
            readTimer.Stop();
            try
            {
                lock (commLock)
                {
                    spektrometr.SetUstawioneImpulsy2(Convert.ToInt32(UstawioneImpulsy2.Value));
                }
            }
            catch (TimeoutException)
            {
                ConnectionErrors.Invoke(new Action(CountErrors));
            }
            readTimer.Start();
        }

        private void Przepisz1_Click(object sender, EventArgs e)
        {
            UstawioneImpulsy1.Value = AktualneImpulsy1.Value;
        }

        private void Przepisz2_Click(object sender, EventArgs e)
        {
            UstawioneImpulsy2.Value = AktualneImpulsy2.Value;
        }

        private void LusterkoWyslij_Click(object sender, EventArgs e)
        {
            readTimer.Stop();
            try
            {
                lock (commLock)
                {
                    spektrometr.SetUstawionyKatLusterko(Convert.ToByte(LusterkoKat.Value));
                }
            }
            catch (TimeoutException)
            {
                ConnectionErrors.Invoke(new Action(CountErrors));
            }
            readTimer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            spektrometr?.Dispose();
            spektrometr = null;
        }

        private void StatusIndicator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
