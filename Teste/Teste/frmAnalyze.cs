﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Drawing;
using System.Drawing;
using System.Data;

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

        private bool _initTest = false;

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
            dt.Columns.Add("Property8", typeof(string));

            for (int i = 0; i < 8; i++)
                dt.Rows.Add(i.ToString(), "Name" + i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString(), i.ToString());

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
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[8], obj[8].ToString());
                    gridView1.UpdateCurrentRow();
                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //gridControl1.ExportToXls()
            //saveFileDialog1.ShowDialog();

            RunSample5();
        }

        /// <summary>
        /// Sample 5 - open Sample 1 and add 2 new rows and a Piechart
        /// </summary>
        public string RunSample5()
        {
            //Set the output directory to the SampleApp folder where the app is running from. 
            Utils.OutputDir = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}SampleApp");

            FileInfo newFile = Utils.GetFileInfo("sample5.xlsx");
            FileInfo templateFile = Utils.GetFileInfo("sample1.xlsx", false);

            Random rnd = new Random();

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Inventory");

                worksheet.InsertRow(1, 1000);

                for (int i = 1; i < 1000; i++)
                {
                    worksheet.Cells[string.Format("A{0}", i)].Value = (i + 10000).ToString();
                    worksheet.Cells[string.Format("B{0}", i)].Value = string.Format("Name #{0}", i);
                    worksheet.Cells[string.Format("C{0}", i)].Value = i;
                    worksheet.Cells[string.Format("D{0}", i)].Value = rnd.Next(0, 1000);
                }

                var chart = (worksheet.Drawings.AddChart("LineMarkers", eChartType.LineMarkers) as ExcelLineChart);
                
                chart.Title.Text = "Total";
                //From row 1 colum 5 with five pixels offset
                chart.SetPosition(0, 0, 5, 5);
                chart.SetSize(800, 600);
                
                ExcelAddress valueAddress = new ExcelAddress(1, 4, 1000, 4);
                //var ser = (chart.Series.Add(valueAddress.Address, "B1:B999") as ExcelPieChartSerie);
                var ser = (chart.Series.Add(valueAddress.Address, "B1:B999") as ExcelLineChartSerie);
                chart.DataLabel.ShowCategory = false;
                chart.DataLabel.ShowPercent = true;

                chart.Legend.Border.LineStyle = eLineStyle.Solid;
                chart.Legend.Border.Fill.Style = eFillStyle.SolidFill;
                chart.Legend.Border.Fill.Color = Color.DarkBlue;

                //Switch the PageLayoutView back to normal
                worksheet.View.PageLayoutView = false;
                // save our new workbook and we are done!
                package.Save();
            }

            return newFile.FullName;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
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
            dt.Columns.Add("Property8", typeof(string));

            gridControl1.DataSource = dt;
            ShowGrid(CreateData());
        }
    }
}
