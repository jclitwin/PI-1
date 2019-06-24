using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Teste
{
    public partial class frmConnection : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmConnection _instance;
        public static frmConnection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmConnection();

                return _instance;
            }
        }

        SerialPort serial;
        SynchronizationContext sync = null;

        private double _torque = 0.0;
        public double Torque
        {
            get { return _torque; }
            set { _torque = value; }
        }

        private double _tracao = 0.0;
        public double Tracao
        {
            get { return _tracao; }
            set { _tracao = value; }
        }

        private int _rpm = 0;
        public int RPM
        {
            get { return _rpm; }
            set { _rpm = value; }
        }

        string msg;

        public bool connected = false;

        public frmConnection()
        {
            InitializeComponent();
            sync = SynchronizationContext.Current;
            simpleButton2.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Log("Connecting...");
                serial = new SerialPort(frmSetup.Instance.Port, frmSetup.Instance.Serial);
                //serial = new SerialPort("COM8", 9600);
                serial.DataReceived += new SerialDataReceivedEventHandler(portDataReceived);
                serial.Parity = Parity.None;
                serial.StopBits = StopBits.One;
                serial.DataBits = 8;
                serial.Handshake = Handshake.None;

                serial.Open();
                if (serial.IsOpen)
                {
                    Log("Port is open.");
                    connected = true;
                }

                simpleButton2.Enabled = connected;
                simpleButton1.Enabled = !connected;

                frmHome.Instance.UpdateStatusConnect(connected);
                frmRPM.Instance.EnableTrackBar(connected);
            }
            catch (Exception ex)
            {
                Log(ex.ToString());
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                connected = false;

                Log("Desconnecting...");

                serial.Close();

                simpleButton2.Enabled = connected;
                simpleButton1.Enabled = !connected;

                frmHome.Instance.UpdateStatusConnect(connected);
                frmRPM.Instance.EnableTrackBar(connected);
            }
            catch (Exception ex)
            {
                Log(ex.ToString());
            }
        }

        public void Log(string log)
        {
            string msg = string.Format("[{0}]: {1}\r\n", DateTime.Now, log);
            memoEdit2.Text += msg;
            memoEdit2.SelectionStart = memoEdit2.Text.Length;
            memoEdit2.ScrollToCaret();
        }

        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp1 = (SerialPort)sender;
            msg = sp1.ReadLine();

            if (msg[0] == ' ')
            {
                msg = msg.Substring(1);
                string[] datas = msg.Split(';');

                _torque = Convert.ToDouble(datas[0]);
                _tracao = Convert.ToDouble(datas[1]);
                _rpm = Convert.ToInt32(datas[2]);

                sync.Post(f =>
                {
                    Log("Torque: " + Convert.ToString(_torque));
                    frmAnalyzeTorque.Instance.SetData(_torque);
                }, _torque);


                sync.Post(f =>
                {
                    Log("Tração: " + Convert.ToString(_tracao));
                    frmAnalyzeTraction.Instance.SetData(_tracao);
                }, _tracao);

                sync.Post(f =>
                {
                    Log("RPM: " + Convert.ToString(_rpm));
                    frmAnalyzeRPM.Instance.SetData(_rpm);
                }, _rpm);
            }

        }

        public void SendRPM(double value)
        {
            int speedValue = Convert.ToInt32((Convert.ToInt32(value) * 100) / 9.7751711);
            serial.Write(Convert.ToString(speedValue) + '\n');
            //serial.Write(Convert.ToString(value) + '\n');
        }
    }
}
