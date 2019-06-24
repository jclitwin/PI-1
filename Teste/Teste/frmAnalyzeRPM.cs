using System;
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

        SynchronizationContext sync = null;

        public frmAnalyzeRPM()
        {
            InitializeComponent();

            chartControl1.BeginInit();
            chartControl1.EndInit();

            sync = SynchronizationContext.Current;

            textEdit1.Text = "Aguardando recebimento de dados...";

            timer1.Interval = 200;
            timer1.Tick += new EventHandler(timer_Tick);
            _rnd = new Random();

            timer1.Start();
        }

        private Random _rnd = null;
        private void timer_Tick(object sender, EventArgs e)
        {
            SetData(_rnd.Next(100, 500) + _rnd.NextDouble());
        }

        public void SetData(double value)
        {
            chartControl1.Series["RPM"].Points.AddPoint(DateTime.Now, value);
            sync.Post(f =>
            {
                textEdit1.Text = "Atual RPM: " + Convert.ToString(value);
            }, value);
        }
    }
}
