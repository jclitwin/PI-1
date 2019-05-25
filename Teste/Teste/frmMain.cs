using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Management;

namespace Teste
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();

            if (!fluentDesignFormContainer1.Controls.Contains(frmHome.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmHome.Instance);
                frmHome.Instance.Dock = DockStyle.Fill;
                frmHome.Instance.BringToFront();
            }
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

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
            if (!fluentDesignFormContainer1.Controls.Contains(frmSpeed.Instance))
            {
                fluentDesignFormContainer1.Controls.Add(frmSpeed.Instance);
                frmSpeed.Instance.Dock = DockStyle.Fill;
                frmSpeed.Instance.BringToFront();
            }

            frmSpeed.Instance.BringToFront();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
