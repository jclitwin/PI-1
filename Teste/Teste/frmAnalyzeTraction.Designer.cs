namespace Teste
{
    partial class frmAnalyzeTraction
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
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram2 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView2 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControl1item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sidePanel1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2item = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmAnalyzeTractionlayoutControl1ConvertedLayout)).BeginInit();
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit1.Location = new System.Drawing.Point(0, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(633, 20);
            this.textEdit1.TabIndex = 12;
            // 
            // chartControl1
            // 
            swiftPlotDiagram2.AxisX.StickToEdge = true;
            swiftPlotDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram2.AxisX.VisualRange.Auto = false;
            swiftPlotDiagram2.AxisX.VisualRange.MaxValueSerializable = "3";
            swiftPlotDiagram2.AxisX.VisualRange.MinValueSerializable = "0";
            swiftPlotDiagram2.AxisX.WholeRange.Auto = false;
            swiftPlotDiagram2.AxisX.WholeRange.MaxValueSerializable = "3";
            swiftPlotDiagram2.AxisX.WholeRange.MinValueSerializable = "0";
            swiftPlotDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram2.DefaultPane.RuntimeCollapse = DevExpress.Utils.DefaultBoolean.True;
            swiftPlotDiagram2.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.False;
            swiftPlotDiagram2.EnableAxisXScrolling = true;
            swiftPlotDiagram2.EnableAxisXZooming = true;
            this.chartControl1.Diagram = swiftPlotDiagram2;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Metro";
            series2.Name = "Traction";
            series2.View = swiftPlotSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(633, 369);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(633, 28);
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
            this.labelControl2.Size = new System.Drawing.Size(141, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Gráfico > Tração";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.chartControl1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(0, 20);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(633, 369);
            this.sidePanel2.TabIndex = 13;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Controls.Add(this.textEdit1);
            this.sidePanel1.Location = new System.Drawing.Point(12, 44);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(633, 389);
            this.sidePanel1.TabIndex = 10;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // frmAnalyzeTractionlayoutControl1ConvertedLayout
            // 
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.Controls.Add(this.sidePanel1);
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.Controls.Add(this.panelControl2);
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.Name = "frmAnalyzeTractionlayoutControl1ConvertedLayout";
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(657, 445);
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.TabIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupControl1item});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(657, 445);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupControl1item
            // 
            this.groupControl1item.GroupBordersVisible = false;
            this.groupControl1item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sidePanel1item,
            this.panelControl2item});
            this.groupControl1item.Location = new System.Drawing.Point(0, 0);
            this.groupControl1item.Name = "groupControl1item";
            this.groupControl1item.Size = new System.Drawing.Size(637, 425);
            this.groupControl1item.Text = "layoutControlGroup1";
            // 
            // sidePanel1item
            // 
            this.sidePanel1item.Control = this.sidePanel1;
            this.sidePanel1item.Location = new System.Drawing.Point(0, 32);
            this.sidePanel1item.Name = "sidePanel1item";
            this.sidePanel1item.Size = new System.Drawing.Size(637, 393);
            this.sidePanel1item.TextSize = new System.Drawing.Size(0, 0);
            this.sidePanel1item.TextVisible = false;
            // 
            // panelControl2item
            // 
            this.panelControl2item.Control = this.panelControl2;
            this.panelControl2item.Location = new System.Drawing.Point(0, 0);
            this.panelControl2item.MaxSize = new System.Drawing.Size(0, 32);
            this.panelControl2item.MinSize = new System.Drawing.Size(5, 32);
            this.panelControl2item.Name = "panelControl2item";
            this.panelControl2item.Size = new System.Drawing.Size(637, 32);
            this.panelControl2item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.panelControl2item.TextSize = new System.Drawing.Size(0, 0);
            this.panelControl2item.TextVisible = false;
            // 
            // frmAnalyzeTraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmAnalyzeTractionlayoutControl1ConvertedLayout);
            this.Name = "frmAnalyzeTraction";
            this.Size = new System.Drawing.Size(657, 445);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmAnalyzeTractionlayoutControl1ConvertedLayout)).EndInit();
            this.frmAnalyzeTractionlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidePanel1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraLayout.LayoutControl frmAnalyzeTractionlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup groupControl1item;
        private DevExpress.XtraLayout.LayoutControlItem sidePanel1item;
        private DevExpress.XtraLayout.LayoutControlItem panelControl2item;
    }
}
