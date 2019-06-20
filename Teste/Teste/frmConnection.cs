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

        double torque = 0.0;
        double tracao = 0.0;
        int rpm = 0;
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
                //serial = new SerialPort(frmSetup.Instance.Port, frmSetup.Instance.Serial);
                serial = new SerialPort("COM8", 9600);
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
        }

        private void portDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp1 = (SerialPort)sender;
            msg = sp1.ReadLine();
            string[] datas = msg.Split(';');

            torque = Convert.ToDouble(datas[0]);
            tracao = Convert.ToDouble(datas[1]);
            rpm = Convert.ToInt32(datas[2]);

            sync.Post(f =>
            {
                Log("Torque: " + Convert.ToString(torque));
                frmAnalyzeTorque.Instance.SetData(torque);
            }, torque);


            sync.Post(f =>
            {
                Log("Tração: " + Convert.ToString(tracao));
                frmAnalyzeTraction.Instance.SetData(tracao);
            }, tracao);

            sync.Post(f =>
            {
                Log("RPM: " + Convert.ToString(rpm));
                frmAnalyzeRPM.Instance.SetData(rpm);
            }, rpm);

        }

        public void SendRPM(double value)
        {
            serial.Write(Convert.ToString(value) + '\n');
        }
    }
}
