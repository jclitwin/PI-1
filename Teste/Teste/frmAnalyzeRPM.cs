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
using DevExpress.XtraCharts;
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

        //Random _rnd;
        SynchronizationContext sync = null;

        public frmAnalyzeRPM()
        {
            InitializeComponent();

            chartControl1.BeginInit();
            chartControl1.EndInit();

            sync = SynchronizationContext.Current;
            //timer1.Interval = 200;
            //timer1.Tick += new EventHandler(timer1_Tick);
            //
            //timer1.Start();
            //
            //_rnd = new Random();
        }

        //void timer1_Tick(object sender, EventArgs e)
        //{
        //    SetData(_rnd.Next(100, 500) + _rnd.NextDouble());
        //}

        public void SetData(double value)
        {
            chartControl1.Series["RPM"].Points.AddPoint(DateTime.Now, value);
            sync.Post(f =>
            {
                textEdit1.Text = Convert.ToString(value);
            }, value);
        }
    }
}
