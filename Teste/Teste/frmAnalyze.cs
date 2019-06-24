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
    public partial class frmAnalyze : DevExpress.XtraEditors.XtraUserControl
    {
        private static frmAnalyze _instance;
        public static frmAnalyze Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmAnalyze();

                return _instance;
            }
        }

        public frmAnalyze()
        {
            InitializeComponent();
        }

        private DataTable CreateData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Property0", typeof(string));
            dt.Columns.Add("Property1", typeof(string));
            dt.Columns.Add("Property2", typeof(string));
            dt.Columns.Add("Property3", typeof(string));
            dt.Columns.Add("Property4", typeof(string));
            dt.Columns.Add("Property5", typeof(string));
            dt.Columns.Add("Property6", typeof(string));
            dt.Columns.Add("Property7", typeof(string));
            for (int i = 0; i < 7; i++)
                dt.Rows.Add(i.ToString(), "Name" + i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString());
            return dt;
        }

        private void ShowGrid(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                object[] obj = dt.Rows[i].ItemArray;
                gridView1.AddNewRow();
                int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
                if (gridView1.IsNewItemRow(rowHandle))
                {
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0], obj[0].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1], obj[1].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[2], obj[2].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[3], obj[3].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4], obj[4].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[5], obj[5].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[6], obj[6].ToString());
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[7], obj[7].ToString());
                    gridView1.UpdateCurrentRow();
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Property0", typeof(string));
            dt.Columns.Add("Property1", typeof(string));
            dt.Columns.Add("Property2", typeof(string));
            dt.Columns.Add("Property3", typeof(string));
            dt.Columns.Add("Property4", typeof(string));
            dt.Columns.Add("Property5", typeof(string));
            dt.Columns.Add("Property6", typeof(string));
            dt.Columns.Add("Property7", typeof(string));

            gridControl1.DataSource = dt;
            ShowGrid(CreateData());
        }
    }
}
