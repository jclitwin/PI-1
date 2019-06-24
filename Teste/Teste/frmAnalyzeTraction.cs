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
    public partial class frmAnalyzeTraction : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmAnalyzeTraction _instance;
        public static frmAnalyzeTraction Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmAnalyzeTraction();

                return _instance;
            }
        }

        SynchronizationContext sync = null;

        public frmAnalyzeTraction()
        {
            InitializeComponent();

            sync = SynchronizationContext.Current;

            chartControl1.BeginInit();
            chartControl1.EndInit();

            textEdit1.Text = "Aguardando recebimento de dados...";
        }

        public void SetData(double value)
        {
            chartControl1.Series["Traction"].Points.AddPoint(DateTime.Now, value);
            sync.Post(f =>
            {
                textEdit1.Text = "Atual Tração: " + Convert.ToString(value);
            }, value);
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
