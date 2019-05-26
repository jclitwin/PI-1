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

        Random _rnd;

        public frmAnalyzeTorque()
        {
            InitializeComponent();

            chartControl1.BeginInit();
            chartControl1.EndInit();

            timer1.Interval = 200;
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Start();

            _rnd = new Random();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            SetData(_rnd.Next(100, 500) + _rnd.NextDouble());
        }

        public void SetData(double value)
        {
            chartControl1.Series["Torque"].Points.AddPoint(DateTime.Now, value);
        }
    }
}
