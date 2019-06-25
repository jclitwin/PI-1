using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;

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

        SerialPort _receivePort;
        SerialPort _sendPort;
        SynchronizationContext sync = null;

        //private ConcurrentQueue<string> _logs = null;
        private Queue<string> _logs = null;

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

        private readonly object _lock= new object();

        public frmConnection()
        {
            InitializeComponent();
            sync = SynchronizationContext.Current;
            simpleButton2.Enabled = false;

            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer_Tick);

            //_logs = new ConcurrentQueue<string>();
            _logs = new Queue<string>();

            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lock (_lock)
            {
                if (_logs.Count > 0)
                {
                    int processLogs = 10;

                    for (int i = 0; i < processLogs; i++)
                    {
                        string msg = _logs.Dequeue();
                        if (!string.IsNullOrEmpty(msg))
                        {
                            memoEdit2.Text += msg;
                            memoEdit2.SelectionStart = memoEdit2.Text.Length;
                            memoEdit2.ScrollToCaret();
                        }
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                Log("Connecting receiver port...");
                _receivePort = new SerialPort(frmSetup.Instance.ReceiverPort, frmSetup.Instance.ReceiverSerial);
                _receivePort = new SerialPort("COM10");
                _receivePort.DataReceived += new SerialDataReceivedEventHandler(portDataReceiverReceived); 
                _receivePort.Parity = Parity.None;
                _receivePort.StopBits = StopBits.One;
                _receivePort.DataBits = 8;
                _receivePort.Handshake = Handshake.None;

                _receivePort.Open();

                if (_receivePort.IsOpen)
                {
                    Log("Receiver Port is open.");
                }

                Log("Connecting sender port...");

                _sendPort = new SerialPort(frmSetup.Instance.SenderPort, frmSetup.Instance.SenderSerial);
                _sendPort = new SerialPort("COM8");
                _sendPort.DataReceived += new SerialDataReceivedEventHandler(portDataSendReceived);
                _sendPort.Parity = Parity.None;
                _sendPort.StopBits = StopBits.One;
                _sendPort.DataBits = 8;
                _sendPort.Handshake = Handshake.None;

                _sendPort.Open();

                if (_sendPort.IsOpen)
                {
                    Log("Sender Port is open.");
                }

                if (_receivePort.IsOpen && _sendPort.IsOpen)
                    //if (_sendPort.IsOpen)
                    connected = true;

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

        private void portDataSendReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp1 = (SerialPort)sender;
            string msg = sp1.ReadLine();

            Log(string.Format("Debug: {0}", msg));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                connected = false;

                Log("Desconnecting...");

                _receivePort.Close();
                _sendPort.Close();

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
            Debug.WriteLine(msg);

            lock (_lock)
            {
                _logs.Enqueue(log);
            }

            //lock (_lock)
            //{
            //    memoEdit2.Text += msg;
            //    memoEdit2.SelectionStart = memoEdit2.Text.Length;
            //    memoEdit2.ScrollToCaret();
            //}
        }

        private void portDataReceiverReceived(object sender, SerialDataReceivedEventArgs e)
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
            _sendPort.Write(Convert.ToString(speedValue) + '\n');
            //serial.Write(Convert.ToString(value) + '\n');
        }
    }
}
