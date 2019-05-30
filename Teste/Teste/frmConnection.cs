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

        double ldrValue = 0;
        double celCarga = 0.0;
        string msg;
        char typeReceiveMsg;

        public bool connected = false;

        public frmConnection()
        {
            InitializeComponent();

            simpleButton2.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Log("Connecting...");
                serial = new SerialPort(frmSetup.Instance.Port, frmSetup.Instance.Serial);
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

                simpleButton2.Enabled = true;
                simpleButton1.Enabled = false;

                frmHome.Instance.UpdateStatusConnect(true);
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

                simpleButton2.Enabled = false;
                simpleButton1.Enabled = true;

                frmHome.Instance.UpdateStatusConnect(false);
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
            typeReceiveMsg = msg[0];
            msg = msg.Substring(1);

            if (typeReceiveMsg == 'L')
            {
                ldrValue = Convert.ToDouble(msg);

                sync.Post(f =>
                {
                    Log("L: " + Convert.ToString(ldrValue));
                    frmAnalyzeRPM.Instance.SetData(ldrValue);
                }, ldrValue);

            }
            if (typeReceiveMsg == 'A')
            {
                celCarga = Convert.ToDouble(msg);

                sync.Post(f =>
                {
                    Log("A: " + Convert.ToString(celCarga));
                    //textBoxCargaA.Text = Convert.ToString(celCarga);
                    frmAnalyzeTorque.Instance.SetData(celCarga);
                }, celCarga);
            }

            if (typeReceiveMsg == 'B')
            {
                celCarga = Convert.ToDouble(msg);

                sync.Post(f =>
                {
                    Log("B: " + Convert.ToString(celCarga));
                    //textBoxCargaB.Text = Convert.ToString(celCarga);
                    frmAnalyzeTraction.Instance.SetData(celCarga);
                }, celCarga);
            }
        }
    }
}
