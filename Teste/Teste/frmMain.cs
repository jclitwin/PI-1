using System;
using IniParser;
using IniParser.Model;
using System.Management;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;
using System.Drawing;

namespace Teste
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly string CONFIG_FILE_NAME = "./config.ini";

        private static frmMain _instance;
        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();

                return _instance;
            }
        }

        public frmMain()
        {
            LoadConfig();

            InitializeComponent();

            if (!fluentDesignFormContainer1.Controls.Contains(frmHome.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmHome.Instance);
                frmHome.Instance.Dock = DockStyle.Fill;
                frmHome.Instance.BringToFront();
            }
        }

        public bool WriteConfig(string portReceiver, int serialReceiver, string portSender, int serialSender, double helixDiameter, double dragForce, double windSpeed)
        {
            var parser = new FileIniDataParser();
            if (File.Exists(CONFIG_FILE_NAME))
            {
                File.Delete(CONFIG_FILE_NAME);
            }

            IniData data = new IniData();
            data["Connection"]["PortReceiver"] = portReceiver;
            data["Connection"]["SerialReceiver"] = serialReceiver.ToString();
            data["Connection"]["PortSender"] = portSender;
            data["Connection"]["SerialSender"] = serialSender.ToString();
            data["Connection"]["HelixDiameter"] = helixDiameter.ToString();
            data["Connection"]["DragForce"] = dragForce.ToString();
            data["Connection"]["WindSpeed"] = windSpeed.ToString();

            //Save the file
            parser.WriteFile(CONFIG_FILE_NAME, data);

            return true;
        }

        private bool LoadConfig()
        {
            var parser = new FileIniDataParser();
            if(File.Exists(CONFIG_FILE_NAME))
            {
                IniData data = parser.ReadFile(CONFIG_FILE_NAME);
                if(data == null)
                {
                    XtraMessageBox.Show("Anormalia encontrada no arquivo de configuração.", "Aviso", MessageBoxButtons.OK);
                    File.Delete(CONFIG_FILE_NAME);

                    return false;
                }

                string portReceiver = data["Connection"]["PortReceiver"].Replace("\"", "");
                int serialReceiver = Convert.ToInt32(data["Connection"]["SerialReceiver"]);

                string portSender = data["Connection"]["PortSender"].Replace("\"", "");
                int serialSender = Convert.ToInt32(data["Connection"]["SerialSender"]);

                double helixDiameter = Convert.ToDouble(data["Connection"]["HelixDiameter"]);
                double dragForce = Convert.ToDouble(data["Connection"]["DragForce"]);
                double windSpeed = Convert.ToDouble(data["Connection"]["WindSpeed"]);

                frmSetup.Instance.ReceiverPort = portReceiver;
                frmSetup.Instance.ReceiverSerial = serialReceiver;

                frmSetup.Instance.SenderPort = portSender;
                frmSetup.Instance.SenderSerial = serialSender;

                frmSetup.Instance.HelixDiameter = helixDiameter;
                frmSetup.Instance.DragForce = dragForce;
                frmSetup.Instance.WindSpeed = windSpeed;

                frmSetup.Instance.LoadSerialPortReceiver();
                frmSetup.Instance.LoadSerialPortSender();

                frmSetup.Instance.GetPortReceiver();
                frmSetup.Instance.GetSerialReceiver();

                frmSetup.Instance.GetPortSender();
                frmSetup.Instance.GetSerialSender();
            }
            else
            {
                return false;
            }

            return true;
        }

        public void GoHomePage()
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmHome.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmHome.Instance);
                frmHome.Instance.Dock = DockStyle.Fill;
                frmHome.Instance.BringToFront();
            }

            frmHome.Instance.BringToFront();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            GoHomePage();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmSetup.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmSetup.Instance);
                frmSetup.Instance.Dock = DockStyle.Fill;
                frmSetup.Instance.BringToFront();
            }

            frmSetup.Instance.BringToFront();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmRPM.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmRPM.Instance);
                frmRPM.Instance.Dock = DockStyle.Fill;
                frmRPM.Instance.BringToFront();
            }

            frmRPM.Instance.BringToFront();
        }

        private void GetSerialPort()
        {

            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PnPEntity");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["Caption"].ToString().Contains("(COM"))
                    {
                        Console.WriteLine("serial port : {0}", queryObj["Caption"]);
                    }

                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmAnalyzeRPM.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmAnalyzeRPM.Instance);
                frmAnalyzeRPM.Instance.Dock = DockStyle.Fill;
                frmAnalyzeRPM.Instance.BringToFront();
            }

            frmAnalyzeRPM.Instance.BringToFront();
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmAnalyzeTorque.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmAnalyzeTorque.Instance);
                frmAnalyzeTorque.Instance.Dock = DockStyle.Fill;
                frmAnalyzeTorque.Instance.BringToFront();
            }

            frmAnalyzeTorque.Instance.BringToFront();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmConnection.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmConnection.Instance);
                frmConnection.Instance.Dock = DockStyle.Fill;
                frmConnection.Instance.BringToFront();
            }

            frmConnection.Instance.BringToFront();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmConnection.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmConnection.Instance);
                frmConnection.Instance.Dock = DockStyle.Fill;
                frmConnection.Instance.BringToFront();
            }

            frmConnection.Instance.BringToFront();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmAnalyzeTraction.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmAnalyzeTraction.Instance);
                frmAnalyzeTraction.Instance.Dock = DockStyle.Fill;
                frmAnalyzeTraction.Instance.BringToFront();
            }

            frmAnalyzeTraction.Instance.BringToFront();
        }

        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmAnalyze.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmAnalyze.Instance);
                frmAnalyze.Instance.Dock = DockStyle.Fill;
                frmAnalyze.Instance.BringToFront();
            }

            frmAnalyze.Instance.BringToFront();
        }
    }
}
