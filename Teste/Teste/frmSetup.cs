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

        private string _receiverPort = "";
        public string ReceiverPort
        {
            get { return _receiverPort; }
            set { _receiverPort = value; }
        }

        private int _receiverSerial = 0;
        public int ReceiverSerial
        {
            get { return _receiverSerial; }
            set { _receiverSerial = value; }
        }

        private string _senderPort = "";
        public string SenderPort
        {
            get { return _senderPort; }
            set { _senderPort = value; }
        }

        private int _senderSerial = 0;
        public int SenderSerial
        {
            get { return _senderSerial; }
            set { _senderSerial = value; }
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

        public void LoadSerialPortReceiver()
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
                    {
                        comboBoxEdit2.Properties.Items.Add(portList[i]);
                    }
                }
            }
        }

        public void LoadSerialPortSender()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();

                bool exists = false;

                for (var i = 0; i < portList.Count; i++)
                {
                    exists = false;

                    for (var k = 0; k < comboBoxEdit3.Properties.Items.Count; k++)
                    {
                        var item = comboBoxEdit3.Properties.Items[k];
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
                    {
                        comboBoxEdit3.Properties.Items.Add(portList[i]);
                    }
                }
            }
        }

        public void GetPortReceiver()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();

                int index = 0;
                foreach(string s in portnames)
                {
                    if(s == ReceiverPort)
                    {
                        comboBoxEdit2.SelectedIndex = index;
                        return;
                    }

                    index++;
                }
            }
        }

        public void GetPortSender()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();

                int index = 0;
                foreach (string s in portnames)
                {
                    if (s == SenderPort)
                    {
                        comboBoxEdit3.SelectedIndex = index;
                        return;
                    }

                    index++;
                }
            }
        }

        public void GetSerialReceiver()
        {
            int index = 0;

            for (var i = 0; i < comboBoxEdit1.Properties.Items.Count; i++, index++)
            {
                var item = comboBoxEdit1.Properties.Items[i];
                if(item.ToString() == ReceiverSerial.ToString())
                {
                    comboBoxEdit1.SelectedIndex = index;
                    return;
                }
            }
        }

        public void GetSerialSender()
        {
            int index = 0;

            for (var i = 0; i < comboBoxEdit4.Properties.Items.Count; i++, index++)
            {
                var item = comboBoxEdit4.Properties.Items[i];
                if (item.ToString() == SenderSerial.ToString())
                {
                    comboBoxEdit4.SelectedIndex = index;
                    return;
                }
            }
        }

        private void comboBoxEdit2_QueryPopUp(object sender, CancelEventArgs e)
        {
            LoadSerialPortReceiver();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string strComReceiver = comboBoxEdit2.SelectedItem as string;
            int indexOfCOMReceiver = strComReceiver.IndexOf(" - ");
            string comReceiver = strComReceiver.Remove(indexOfCOMReceiver, strComReceiver.Length - indexOfCOMReceiver);

            string strComSender = comboBoxEdit3.SelectedItem as string;
            int indexOfCOMSender = strComSender.IndexOf(" - ");
            string comSender = strComSender.Remove(indexOfCOMSender, strComSender.Length - indexOfCOMSender);

            ReceiverPort = comReceiver;
            ReceiverSerial = Convert.ToInt32(comboBoxEdit1.SelectedItem);

            SenderPort = comSender;
            SenderSerial = Convert.ToInt32(comboBoxEdit4.SelectedItem);

            HelixDiameter = Convert.ToDouble(textEdit1.Text);
            DragForce = Convert.ToDouble(textEdit2.Text);
            WindSpeed = Convert.ToDouble(textEdit3.Text);

            frmMain.Instance.WriteConfig(ReceiverPort, ReceiverSerial, SenderPort, SenderSerial, HelixDiameter, DragForce, WindSpeed);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmMain.Instance.GoHomePage();
        }

        private void comboBoxEdit3_QueryPopUp(object sender, CancelEventArgs e)
        {
            LoadSerialPortSender();
        }
    }
}
