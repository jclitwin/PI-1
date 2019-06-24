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

        public frmAnalyzeTorque()
        {
            InitializeComponent();

            sync = SynchronizationContext.Current;

            chartControl1.BeginInit();
            chartControl1.EndInit();

            textEdit1.Text = "Aguardando recebimento de dados...";
        }

        public void SetData(double value)
        {
            chartControl1.Series["Torque"].Points.AddPoint(DateTime.Now, value);
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
