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
using System.Management;
using System.IO.Ports;

namespace Teste
{
    public partial class frmHome : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmHome _instance;
        public static frmHome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmHome();

                return _instance;
            }
        }

        public frmHome()
        {
            InitializeComponent();
        }
    }
}
