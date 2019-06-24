namespace Teste
{
    partial class frmAnalyze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyze));
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProperty0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProperty7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.frmAnalyzelayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControl1item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleButton3item = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmAnalyzelayoutControl1ConvertedLayout)).BeginInit();
            this.frmAnalyzelayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton3item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 47);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(633, 346);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(633, 346);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProperty0,
            this.colProperty1,
            this.colProperty2,
            this.colProperty3,
            this.colProperty4,
            this.colProperty5,
            this.colProperty6,
            this.colProperty7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colProperty0
            // 
            this.colProperty0.Caption = "RPM";
            this.colProperty0.FieldName = "Property0";
            this.colProperty0.Name = "colProperty0";
            this.colProperty0.Visible = true;
            this.colProperty0.VisibleIndex = 0;
            this.colProperty0.Width = 67;
            // 
            // colProperty1
            // 
            this.colProperty1.Caption = "V\'";
            this.colProperty1.FieldName = "Property1";
            this.colProperty1.Name = "colProperty1";
            this.colProperty1.Visible = true;
            this.colProperty1.VisibleIndex = 1;
            this.colProperty1.Width = 42;
            // 
            // colProperty2
            // 
            this.colProperty2.Caption = "J";
            this.colProperty2.FieldName = "Property2";
            this.colProperty2.Name = "colProperty2";
            this.colProperty2.Visible = true;
            this.colProperty2.VisibleIndex = 2;
            this.colProperty2.Width = 42;
            // 
            // colProperty3
            // 
            this.colProperty3.Caption = "Np";
            this.colProperty3.FieldName = "Property3";
            this.colProperty3.Name = "colProperty3";
            this.colProperty3.Visible = true;
            this.colProperty3.VisibleIndex = 3;
            this.colProperty3.Width = 42;
            // 
            // colProperty4
            // 
            this.colProperty4.Caption = "Ct";
            this.colProperty4.FieldName = "Property4";
            this.colProperty4.Name = "colProperty4";
            this.colProperty4.Visible = true;
            this.colProperty4.VisibleIndex = 4;
            this.colProperty4.Width = 42;
            // 
            // colProperty5
            // 
            this.colProperty5.Caption = "Cp";
            this.colProperty5.FieldName = "Property5";
            this.colProperty5.Name = "colProperty5";
            this.colProperty5.Visible = true;
            this.colProperty5.VisibleIndex = 5;
            this.colProperty5.Width = 42;
            // 
            // colProperty6
            // 
            this.colProperty6.Caption = "Torque (Q)";
            this.colProperty6.FieldName = "Property6";
            this.colProperty6.Name = "colProperty6";
            this.colProperty6.Visible = true;
            this.colProperty6.VisibleIndex = 6;
            this.colProperty6.Width = 42;
            // 
            // colProperty7
            // 
            this.colProperty7.Caption = "Tração (T)";
            this.colProperty7.FieldName = "Property7";
            this.colProperty7.Name = "colProperty7";
            this.colProperty7.Visible = true;
            this.colProperty7.VisibleIndex = 7;
            this.colProperty7.Width = 54;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(633, 31);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Análise";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 397);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(304, 36);
            this.simpleButton1.StyleController = this.frmAnalyzelayoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Iniciar Teste";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(320, 397);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(325, 36);
            this.simpleButton3.StyleController = this.frmAnalyzelayoutControl1ConvertedLayout;
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Salvar Dados";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // frmAnalyzelayoutControl1ConvertedLayout
            // 
            this.frmAnalyzelayoutControl1ConvertedLayout.Controls.Add(this.simpleButton3);
            this.frmAnalyzelayoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.frmAnalyzelayoutControl1ConvertedLayout.Controls.Add(this.panelControl2);
            this.frmAnalyzelayoutControl1ConvertedLayout.Controls.Add(this.panelControl1);
            this.frmAnalyzelayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmAnalyzelayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmAnalyzelayoutControl1ConvertedLayout.Name = "frmAnalyzelayoutControl1ConvertedLayout";
            this.frmAnalyzelayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmAnalyzelayoutControl1ConvertedLayout.Size = new System.Drawing.Size(657, 445);
            this.frmAnalyzelayoutControl1ConvertedLayout.TabIndex = 20;
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
            this.simpleButton3item,
            this.simpleButton1item,
            this.groupControl2item});
            this.groupControl1item.Location = new System.Drawing.Point(0, 0);
            this.groupControl1item.Name = "groupControl1item";
            this.groupControl1item.Size = new System.Drawing.Size(637, 425);
            this.groupControl1item.Text = "layoutControlGroup1";
            // 
            // simpleButton3item
            // 
            this.simpleButton3item.Control = this.simpleButton3;
            this.simpleButton3item.Location = new System.Drawing.Point(308, 385);
            this.simpleButton3item.Name = "simpleButton3item";
            this.simpleButton3item.Size = new System.Drawing.Size(329, 40);
            this.simpleButton3item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton3item.TextVisible = false;
            // 
            // simpleButton1item
            // 
            this.simpleButton1item.Control = this.simpleButton1;
            this.simpleButton1item.Location = new System.Drawing.Point(0, 385);
            this.simpleButton1item.Name = "simpleButton1item";
            this.simpleButton1item.Size = new System.Drawing.Size(308, 40);
            this.simpleButton1item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton1item.TextVisible = false;
            // 
            // groupControl2item
            // 
            this.groupControl2item.GroupBordersVisible = false;
            this.groupControl2item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.panelControl2item,
            this.panelControl1item});
            this.groupControl2item.Location = new System.Drawing.Point(0, 0);
            this.groupControl2item.Name = "groupControl2item";
            this.groupControl2item.Size = new System.Drawing.Size(637, 385);
            this.groupControl2item.Text = "layoutControlGroup1";
            // 
            // panelControl2item
            // 
            this.panelControl2item.Control = this.panelControl2;
            this.panelControl2item.Location = new System.Drawing.Point(0, 0);
            this.panelControl2item.MaxSize = new System.Drawing.Size(0, 35);
            this.panelControl2item.MinSize = new System.Drawing.Size(5, 35);
            this.panelControl2item.Name = "panelControl2item";
            this.panelControl2item.Size = new System.Drawing.Size(637, 35);
            this.panelControl2item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.panelControl2item.TextSize = new System.Drawing.Size(0, 0);
            this.panelControl2item.TextVisible = false;
            // 
            // panelControl1item
            // 
            this.panelControl1item.Control = this.panelControl1;
            this.panelControl1item.Location = new System.Drawing.Point(0, 35);
            this.panelControl1item.Name = "panelControl1item";
            this.panelControl1item.Size = new System.Drawing.Size(637, 350);
            this.panelControl1item.TextSize = new System.Drawing.Size(0, 0);
            this.panelControl1item.TextVisible = false;
            // 
            // frmAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmAnalyzelayoutControl1ConvertedLayout);
            this.Name = "frmAnalyze";
            this.Size = new System.Drawing.Size(657, 445);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmAnalyzelayoutControl1ConvertedLayout)).EndInit();
            this.frmAnalyzelayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton3item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty0;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty1;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty2;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty3;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty4;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty5;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty6;
        private DevExpress.XtraGrid.Columns.GridColumn colProperty7;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControl frmAnalyzelayoutControl1ConvertedLayout;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup groupControl1item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton3item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton1item;
        private DevExpress.XtraLayout.LayoutControlGroup groupControl2item;
        private DevExpress.XtraLayout.LayoutControlItem panelControl2item;
        private DevExpress.XtraLayout.LayoutControlItem panelControl1item;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
