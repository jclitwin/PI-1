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

                string port = data["Connection"]["Port"].Replace("\"", "");
                int serial = Convert.ToInt32(data["Connection"]["Serial"]);

                frmSetup.Instance.Port = port;
                frmSetup.Instance.Serial = serial;

                frmSetup.Instance.LoadSerialPort();
                frmSetup.Instance.GetPort();
                frmSetup.Instance.GetSerial();

            }
            else
            {
                return false;
            }

            return true;
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            if (!fluentDesignFormContainer1.Controls.Contains(frmHome.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmHome.Instance);
                frmHome.Instance.Dock = DockStyle.Fill;
                frmHome.Instance.BringToFront();
            }

            frmHome.Instance.BringToFront();
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
    }
}
