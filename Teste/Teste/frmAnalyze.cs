﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Drawing;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

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
        private DataTable _dt = null;
        Random random = null;

        public frmAnalyze()
        {
            InitializeComponent();

            _dt = new DataTable();
            random = new Random();

            _dt.Columns.Add("Property0", typeof(string));
            _dt.Columns.Add("Property1", typeof(string));
            _dt.Columns.Add("Property2", typeof(string));
            _dt.Columns.Add("Property3", typeof(string));
            _dt.Columns.Add("Property4", typeof(string));
            _dt.Columns.Add("Property5", typeof(string));
            _dt.Columns.Add("Property6", typeof(string));
            _dt.Columns.Add("Property7", typeof(string));
            _dt.Columns.Add("Property8", typeof(string));
            _dt.Columns.Add("Property9", typeof(string));

            //simpleButton3.Enabled = false;
        }

        private DataTable CreateDinamicData()
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
            dt.Columns.Add("Property9", typeof(string));

            double forcaTracao = frmConnection.Instance.Tracao;
            double forcaTorque = frmConnection.Instance.Torque;
            int rpm = frmConnection.Instance.RPM;
            rpm = random.Next(0, 1000);

            double diametro = frmSetup.Instance.HelixDiameter;
            double fd = frmSetup.Instance.DragForce;
            double velocidade = frmSetup.Instance.WindSpeed;

            double comprimentoHaste = 17.25f;

            double rps = rpm / 60;
            double densidade = 1.225;
            double tracao = forcaTracao + fd;
            double torqueResultante = forcaTorque * comprimentoHaste;
            double potencia = 2 * Math.PI * rps * torqueResultante;
            double ap = (Math.PI * Math.Pow(diametro, 2)) / 4;
            double awt = 0.36;
            double correcao = tracao / (densidade * ap * Math.Pow(velocidade, 2));
            double velocidadeCorrecao = velocidade * (1 - (correcao * (ap / awt)) / (2 * Math.Sqrt(1 + 2 * correcao)));
            double j = velocidadeCorrecao / (rps * diametro);
            double coeficienteTracao = tracao / (densidade * Math.Pow(rps, 2) * Math.Pow(diametro, 4));
            double coeficienteTorque = torqueResultante / (densidade * Math.Pow(rps, 2) * Math.Pow(diametro, 5));
            double coeficientePotencia = potencia / (densidade * Math.Pow(rps, 3) * Math.Pow(diametro, 5));
            double eficienciaHelice = j * (coeficienteTracao / coeficientePotencia);

            _dt.Rows.Add(rpm, "Dinâmico", velocidadeCorrecao, j, eficienciaHelice, coeficienteTracao, coeficienteTorque, torqueResultante, tracao, "Remover");

            return dt;
        }

        private DataTable CreateStaticData()
        {
            DataTable dt = new DataTable();

            //dt.Columns.Add("Property0", typeof(string));
            //dt.Columns.Add("Property1", typeof(string));
            //dt.Columns.Add("Property2", typeof(string));
            //dt.Columns.Add("Property3", typeof(string));
            //dt.Columns.Add("Property4", typeof(string));
            //dt.Columns.Add("Property5", typeof(string));
            //dt.Columns.Add("Property6", typeof(string));
            //dt.Columns.Add("Property7", typeof(string));
            //dt.Columns.Add("Property8", typeof(string));

            //for (int i = 0; i < 8; i++)

            double forcaTracao = frmConnection.Instance.Tracao;
            double forcaTorque = frmConnection.Instance.Torque;
            int rpm = frmConnection.Instance.RPM;
            rpm = random.Next(0, 1000);

            double diametro = frmSetup.Instance.HelixDiameter;
            double fd = frmSetup.Instance.DragForce;

            double comprimentoHaste = 17.25f;

            double rps = rpm / 60;
            double densidade = 1.225;
            double tracao = forcaTracao + fd;
            double torqueResultante = forcaTorque * comprimentoHaste;
            double potencia = 2 * Math.PI * rps * torqueResultante;
            double velocidadeCorrecao = 0;
            double j = 0;
            double coeficienteTracao = tracao / (densidade * Math.Pow(rps, 2) * Math.Pow(diametro, 4));
            double coeficienteTorque = torqueResultante / (densidade * Math.Pow(rps, 2) * Math.Pow(diametro, 5));
            double coeficientePotencia = potencia / (densidade * Math.Pow(rps, 3) * Math.Pow(diametro, 5));
            double eficienciaHelice = j * (coeficienteTracao / coeficientePotencia);

            _dt.Rows.Add(rpm, "Estático", velocidadeCorrecao, j, eficienciaHelice, coeficienteTracao, coeficienteTorque, torqueResultante, tracao, "Remover");
            dt.DefaultView.Sort = "Property0 asc";
            dt = _dt.DefaultView.ToTable();
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
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[9], obj[9].ToString());
                    gridView1.UpdateCurrentRow();
                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Microsoft Excel (*.xlsx)|*.xlsx";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<AnalyzeData> rpm = frmAnalyzeRPM.Instance.ValuesRPM;
                List<AnalyzeData> torque = frmAnalyzeTorque.Instance.ValuesTorque;
                List<AnalyzeData> traction = frmAnalyzeTraction.Instance.ValuesTraction;

                Save(saveFileDialog1.FileName, rpm, torque, traction);
            }
        }

        private string Save(string filePath, List<AnalyzeData> rpm, List<AnalyzeData> torque, List<AnalyzeData> traction)
        {
            //Set the output directory to the SampleApp folder where the app is running from. 
            //Utils.OutputDir = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}SampleApp");

            string path = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);

            Utils.OutputDir = new DirectoryInfo(path);
            FileInfo newFile = Utils.GetFileInfo(fileName, true);

            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ////////////////////////////////////////////////////////////////////
                /// RPM
                ////////////////////////////////////////////////////////////////////
                if(rpm != null && rpm.Count > 0)
                {
                    ExcelWorksheet worksheetRPM = package.Workbook.Worksheets.Add("RPM");

                    worksheetRPM.InsertRow(1, rpm.Count + 1);

                    worksheetRPM.Cells["A1"].Value = "Índices";
                    worksheetRPM.Cells["B1"].Value = "Horários";
                    worksheetRPM.Cells["C1"].Value = "Valor";

                    for (int i = 0; i < rpm.Count; i++)
                    {
                        int idx = i + 1 + 1;
                        AnalyzeData data = rpm[i];
                        if (data == null)
                            continue;

                        worksheetRPM.Cells[string.Format("A{0}", idx)].Value = idx - 1;
                        worksheetRPM.Cells[string.Format("B{0}", idx)].Value = data.Now.ToString();
                        worksheetRPM.Cells[string.Format("C{0}", idx)].Value = data.Value;
                    }

                    var chart = (worksheetRPM.Drawings.AddChart("LineMarkers", eChartType.LineMarkers) as ExcelLineChart);

                    chart.Title.Text = "Gráfico RPM";
                    //From row 1 colum 5 with five pixels offset
                    chart.SetPosition(0, 0, 5, 5);
                    chart.SetSize(800, 600);

                    ExcelAddress valueAddress = new ExcelAddress(2, 3, rpm.Count, 3);
                    var ser = (chart.Series.Add(valueAddress.Address, string.Format("B{0}:B{1}", 1, rpm.Count)) as ExcelLineChartSerie);
                    chart.DataLabel.ShowCategory = false;
                    chart.DataLabel.ShowPercent = true;

                    chart.Legend.Border.LineStyle = eLineStyle.Solid;
                    chart.Legend.Border.Fill.Style = eFillStyle.SolidFill;
                    //chart.Legend.Border.Fill.Color = Color.DarkBlue;

                    //Switch the PageLayoutView back to normal
                    worksheetRPM.View.PageLayoutView = false;
                }
                

                ////////////////////////////////////////////////////////////////////
                /// TORQUE
                ////////////////////////////////////////////////////////////////////

                if(torque != null && torque.Count > 0)
                {
                    ExcelWorksheet worksheetTorque = package.Workbook.Worksheets.Add("Torque");

                    worksheetTorque.InsertRow(1, torque.Count + 1);

                    worksheetTorque.Cells["A1"].Value = "Índices";
                    worksheetTorque.Cells["B1"].Value = "Horários";
                    worksheetTorque.Cells["C1"].Value = "Valor";

                    for (int i = 0; i < torque.Count; i++)
                    {
                        int idx = i + 1 + 1;
                        AnalyzeData data = torque[i];
                        if (data == null)
                            continue;

                        worksheetTorque.Cells[string.Format("A{0}", idx)].Value = idx - 1;
                        worksheetTorque.Cells[string.Format("B{0}", idx)].Value = data.Now.ToString();
                        worksheetTorque.Cells[string.Format("C{0}", idx)].Value = data.Value;
                    }

                    var chartTorque = (worksheetTorque.Drawings.AddChart("LineMarkers", eChartType.LineMarkers) as ExcelLineChart);

                    chartTorque.Title.Text = "Gráfico Tração";
                    //From row 1 colum 5 with five pixels offset
                    chartTorque.SetPosition(0, 0, 5, 5);
                    chartTorque.SetSize(800, 600);

                    ExcelAddress valueAddressTorque = new ExcelAddress(2, 3, torque.Count, 3);
                    var serTorque = (chartTorque.Series.Add(valueAddressTorque.Address, string.Format("B{0}:B{1}", 1, torque.Count)) as ExcelLineChartSerie);
                    chartTorque.DataLabel.ShowCategory = false;
                    chartTorque.DataLabel.ShowPercent = true;

                    chartTorque.Legend.Border.LineStyle = eLineStyle.Solid;
                    chartTorque.Legend.Border.Fill.Style = eFillStyle.SolidFill;
                    chartTorque.Legend.Border.Fill.Color = Color.DarkBlue;

                    //Switch the PageLayoutView back to normal
                    worksheetTorque.View.PageLayoutView = false;
                }
                

                ////////////////////////////////////////////////////////////////////
                /// Traction
                ////////////////////////////////////////////////////////////////////

                if(traction != null && traction.Count > 0)
                {
                    ExcelWorksheet worksheetTraction = package.Workbook.Worksheets.Add("Tração");

                    worksheetTraction.InsertRow(1, traction.Count + 1);

                    worksheetTraction.Cells["A1"].Value = "Índices";
                    worksheetTraction.Cells["B1"].Value = "Horários";
                    worksheetTraction.Cells["C1"].Value = "Valor";

                    for (int i = 0; i < traction.Count; i++)
                    {
                        int idx = i + 1;
                        AnalyzeData data = traction[i];
                        if (data == null)
                            continue;

                        worksheetTraction.Cells[string.Format("A{0}", idx)].Value = idx - 1;
                        worksheetTraction.Cells[string.Format("B{0}", idx)].Value = data.Now.ToString();
                        worksheetTraction.Cells[string.Format("C{0}", idx)].Value = data.Value;
                    }

                    var chartTraction = (worksheetTraction.Drawings.AddChart("LineMarkers", eChartType.LineMarkers) as ExcelLineChart);

                    chartTraction.Title.Text = "Gráfico Torque";

                    //From row 1 colum 5 with five pixels offset
                    chartTraction.SetPosition(0, 0, 5, 5);
                    chartTraction.SetSize(800, 600);

                    ExcelAddress valueAddressTraction = new ExcelAddress(2, 3, torque.Count, 3);
                    var serTraction = (chartTraction.Series.Add(valueAddressTraction.Address, string.Format("B{0}:B{1}", 1, traction.Count)) as ExcelLineChartSerie);
                    chartTraction.DataLabel.ShowCategory = false;
                    chartTraction.DataLabel.ShowPercent = true;

                    chartTraction.Legend.Border.LineStyle = eLineStyle.Solid;
                    chartTraction.Legend.Border.Fill.Style = eFillStyle.SolidFill;
                    chartTraction.Legend.Border.Fill.Color = Color.DarkBlue;

                    //Switch the PageLayoutView back to normal
                    worksheetTraction.View.PageLayoutView = false;
                }
                

                // save our new workbook and we are done!
                package.Save();
            }

            return newFile.FullName;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            gridControl1.DataSource = _dt;
            ShowGrid(CreateStaticData());


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = _dt;
            ShowGrid(CreateDinamicData());

            _dt.DefaultView.Sort = "Property0 asc";
            _dt = _dt.DefaultView.ToTable();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "Property9")
            {
                GridHitInfo hitInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));
                _dt.Rows[hitInfo.RowHandle].Delete();
            }
        }

        //private void gridView1_Sorting(object sender, GridViewSortEventArgs e)
        //{

        //}
    }

    //GridHitInfo hitInfo = gridView1.CalcHitInfo(new Point(e.X, e.Y));

    //if (((e.Button & MouseButtons.Left) != 0) && (hitInfo.InRowCell))
    //{
    //    if (gridView1.GetRowCellDisplayText(hitInfo.RowHandle, hitInfo.Column) == "Remover")
    //    {
    //        _dt.Rows[hitInfo.RowHandle].Delete();
    //    }
    //}
}
