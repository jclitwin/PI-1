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
using System.Threading;
using System.Diagnostics;

namespace Teste
{
    public partial class frmAnalyzeTorque : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmAnalyzeTorque _instance;
        public static frmAnalyzeTorque Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmAnalyzeTorque();

                return _instance;
            }
        }

        SynchronizationContext sync = null;

        List<AnalyzeData> _valuesLst = null;
        public List<AnalyzeData> ValuesTorque
        {
            get
            {
                return _valuesLst;
            }
        }

        Stopwatch _stopwatch = null;

        public frmAnalyzeTorque()
        {
            InitializeComponent();

            sync = SynchronizationContext.Current;

            chartControl1.BeginInit();
            chartControl1.EndInit();

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

            chartControl1.Series["Torque"].Points.AddPoint(now, value);
            sync.Post(f =>
            {
                textEdit1.Text = "Atual Torque: " + Convert.ToString(value);
            }, value);
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
