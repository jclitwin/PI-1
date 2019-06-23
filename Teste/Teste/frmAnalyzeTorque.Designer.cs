namespace Teste
{
    partial class frmAnalyzeTorque
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sidePanel1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmAnalyzeTorquelayoutControl1ConvertedLayout)).BeginInit();
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.panelControl1);
            this.sidePanel1.Location = new System.Drawing.Point(12, 48);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(633, 385);
            this.sidePanel1.TabIndex = 10;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.chartControl1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(627, 385);
            this.panelControl1.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(480, 82);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(84, 20);
            this.textEdit1.TabIndex = 12;
            // 
            // chartControl1
            // 
            swiftPlotDiagram1.AxisX.StickToEdge = true;
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisX.VisualRange.Auto = false;
            swiftPlotDiagram1.AxisX.VisualRange.MaxValueSerializable = "3";
            swiftPlotDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            swiftPlotDiagram1.AxisX.WholeRange.Auto = false;
            swiftPlotDiagram1.AxisX.WholeRange.MaxValueSerializable = "3";
            swiftPlotDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.DefaultPane.RuntimeCollapse = DevExpress.Utils.DefaultBoolean.True;
            swiftPlotDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.False;
            swiftPlotDiagram1.EnableAxisXScrolling = true;
            swiftPlotDiagram1.EnableAxisXZooming = true;
            this.chartControl1.Diagram = swiftPlotDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(15, 26);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Orange";
            series1.Name = "Torque";
            series1.View = swiftPlotSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(560, 350);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Leitura do Torque";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(633, 32);
            this.panelControl2.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Análise > Torque";
            // 
            // frmAnalyzeTorquelayoutControl1ConvertedLayout
            // 
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.Controls.Add(this.sidePanel1);
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.Controls.Add(this.panelControl2);
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.Name = "frmAnalyzeTorquelayoutControl1ConvertedLayout";
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.Size = new System.Drawing.Size(657, 445);
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sidePanel1item,
            this.panelControl2item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(657, 445);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // sidePanel1item
            // 
            this.sidePanel1item.Control = this.sidePanel1;
            this.sidePanel1item.Location = new System.Drawing.Point(0, 36);
            this.sidePanel1item.Name = "sidePanel1item";
            this.sidePanel1item.Size = new System.Drawing.Size(637, 389);
            this.sidePanel1item.TextSize = new System.Drawing.Size(0, 0);
            this.sidePanel1item.TextVisible = false;
            // 
            // panelControl2item
            // 
            this.panelControl2item.Control = this.panelControl2;
            this.panelControl2item.Location = new System.Drawing.Point(0, 0);
            this.panelControl2item.MaxSize = new System.Drawing.Size(0, 36);
            this.panelControl2item.MinSize = new System.Drawing.Size(5, 36);
            this.panelControl2item.Name = "panelControl2item";
            this.panelControl2item.Size = new System.Drawing.Size(637, 36);
            this.panelControl2item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.panelControl2item.TextSize = new System.Drawing.Size(0, 0);
            this.panelControl2item.TextVisible = false;
            // 
            // frmAnalyzeTorque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmAnalyzeTorquelayoutControl1ConvertedLayout);
            this.Name = "frmAnalyzeTorque";
            this.Size = new System.Drawing.Size(657, 445);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmAnalyzeTorquelayoutControl1ConvertedLayout)).EndInit();
            this.frmAnalyzeTorquelayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControl frmAnalyzeTorquelayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem sidePanel1item;
        private DevExpress.XtraLayout.LayoutControlItem panelControl2item;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
