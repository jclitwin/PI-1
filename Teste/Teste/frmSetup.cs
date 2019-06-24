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

        private string _port = "";
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }

        private int _serial = 0;
        public int Serial
        {
            get { return _serial; }
            set { _serial = value; }
        }

        private double _helixDiameter = 0;
        public double HelixDiameter
        {
            get { return _helixDiameter; }
            set { _helixDiameter = value; }
        }

        private double _dragForce = 0;
        public double DragForce
        {
            get { return _dragForce; }
            set { _dragForce = value; }
        }

        private double _windSpeed = 0;
        public double WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; }
        }

        public frmSetup()
        {
            InitializeComponent();
        }

        public void LoadSerialPort()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                bool exists = false;

                for(var i = 0; i < portList.Count; i++)
                {
                    exists = false;

                    for (var k = 0; k < comboBoxEdit2.Properties.Items.Count; k++)
                    {
                        var item = comboBoxEdit2.Properties.Items[k];
                        int indexOf = item.ToString().IndexOf(" - ");
                        if (indexOf < ("COMX".Length))
                            continue;

                        string namePort = item.ToString().Remove(indexOf);
                        if (namePort == portnames[i])
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                        comboBoxEdit2.Properties.Items.Add(portList[i]);
                }
            }
        }

        public void GetPort()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();

                int index = 0;
                foreach(string s in portnames)
                {
                    if(s == Port)
                    {
                        comboBoxEdit2.SelectedIndex = index;
                        return;
                    }

                    index++;
                }
            }
        }

        public void GetSerial()
        {
            int index = 0;

            for (var i = 0; i < comboBoxEdit1.Properties.Items.Count; i++, index++)
            {
                var item = comboBoxEdit1.Properties.Items[i];
                if(item.ToString() == Serial.ToString())
                {
                    comboBoxEdit1.SelectedIndex = index;
                    return;
                }
            }
        }

        private void comboBoxEdit2_QueryPopUp(object sender, CancelEventArgs e)
        {
            LoadSerialPort();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string strCom = comboBoxEdit2.SelectedItem as string;

            int indexOfCOM = strCom.IndexOf(" - ");
            int count = strCom.Length - indexOfCOM;
            string com = strCom.Remove(indexOfCOM, count);

            Port = com;
            Serial = Convert.ToInt32(comboBoxEdit1.SelectedItem);
            HelixDiameter = Convert.ToDouble(textEdit1.Text);
            DragForce = Convert.ToDouble(textEdit2.Text);
            WindSpeed = Convert.ToDouble(textEdit3.Text);

            frmMain.Instance.WriteConfig(Port, Serial, HelixDiameter, DragForce, WindSpeed);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmMain.Instance.GoHomePage();
        }

        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
    }
}
