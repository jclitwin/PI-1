using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Management;
using System.IO.Ports;

namespace Teste
{
    public partial class frmSetup : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmSetup _instance;

        public static frmSetup Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmSetup();

                return _instance;
            }
        }

        public frmSetup()
        {
            InitializeComponent();
        }

        private void GetSerialPort()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                foreach (string s in portList)
                {
                    comboBoxEdit2.Properties.Items.Add(s);
                }
            }
        }

        private void comboBoxEdit2_QueryPopUp(object sender, CancelEventArgs e)
        {
            comboBoxEdit2.Properties.Items.Clear();
            GetSerialPort();
        }
    }
}
