using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Teste
{
    public partial class frmAnalyzeRPM : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmAnalyzeRPM _instance;
        public static frmAnalyzeRPM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmAnalyzeRPM();

                return _instance;
            }
        }

        SynchronizationContext _sync = null;

        List<AnalyzeData> _valuesLst = null;
        public List<AnalyzeData> ValuesRPM
        {
            get
            {
                return _valuesLst;
            }
        }

        Stopwatch _stopwatch = null;

        public frmAnalyzeRPM()
        {
            InitializeComponent();

            chartControl1.BeginInit();
            chartControl1.EndInit();

            _sync = SynchronizationContext.Current;

            _valuesLst = new List<AnalyzeData>();

            textEdit1.Text = "Aguardando recebimento de dados...";

            timer1.Interval = 200;
            timer1.Tick += new EventHandler(timer_Tick);
            _rnd = new Random();
            
            //timer1.Start();
        }

        public void StartTest()
        {
            if (_stopwatch == null)
                _stopwatch = new Stopwatch();

            _stopwatch.Start();
        }

        public void StopTest()
        {
            _stopwatch.Stop();
        }

        private Random _rnd = null;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (_stopwatch == null)
                StartTest();

            SetData(_rnd.Next(100, 500) + _rnd.NextDouble());
        }

        public void SetData(double value)
        {
            DateTime now = DateTime.Now;
            //long ticks = _stopwatch.ElapsedTicks;

            AnalyzeData data = new AnalyzeData();
            data.Now = now;
            data.Value = value;
            data.Ticks = 0;

            _valuesLst.Add(data);

            chartControl1.Series["RPM"].Points.AddPoint(now, value);
            _sync.Post(f =>
            {
                textEdit1.Text = "Atual RPM: " + Convert.ToString(value);
            }, value);
        }
    }
}
