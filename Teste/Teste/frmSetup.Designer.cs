namespace Teste
{
    partial class frmSetup
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.frmSetuplayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleButton2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPane1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl2item = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetuplayoutControl1ConvertedLayout)).BeginInit();
            this.frmSetuplayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(12, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(646, 43);
            this.panelControl2.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 25);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Configuração";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Location = new System.Drawing.Point(12, 59);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(646, 359);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(646, 359);
            this.tabPane1.TabIndex = 5;
            this.tabPane1.Text = "Conexão";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Conexão";
            this.tabNavigationPage1.Controls.Add(this.comboBoxEdit2);
            this.tabNavigationPage1.Controls.Add(this.labelControl3);
            this.tabNavigationPage1.Controls.Add(this.labelControl1);
            this.tabNavigationPage1.Controls.Add(this.comboBoxEdit1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(646, 330);
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.EditValue = "Selecione a porta do Bluetooth";
            this.comboBoxEdit2.Location = new System.Drawing.Point(15, 32);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit2.Size = new System.Drawing.Size(303, 20);
            this.comboBoxEdit2.TabIndex = 3;
            this.comboBoxEdit2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.comboBoxEdit2_QueryPopUp);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Portas:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Rate:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Selecione a frequência";
            this.comboBoxEdit1.Location = new System.Drawing.Point(15, 77);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "1200",
            "2400",
            "9600",
            "19200",
            "28800"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(109, 20);
            this.comboBoxEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 422);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(321, 22);
            this.simpleButton1.StyleController = this.frmSetuplayoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Salvar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmSetuplayoutControl1ConvertedLayout
            // 
            this.frmSetuplayoutControl1ConvertedLayout.Controls.Add(this.simpleButton2);
            this.frmSetuplayoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.frmSetuplayoutControl1ConvertedLayout.Controls.Add(this.tabPane1);
            this.frmSetuplayoutControl1ConvertedLayout.Controls.Add(this.panelControl2);
            this.frmSetuplayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSetuplayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.frmSetuplayoutControl1ConvertedLayout.Name = "frmSetuplayoutControl1ConvertedLayout";
            this.frmSetuplayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-990, 182, 650, 400);
            this.frmSetuplayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.frmSetuplayoutControl1ConvertedLayout.Size = new System.Drawing.Size(670, 456);
            this.frmSetuplayoutControl1ConvertedLayout.TabIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(337, 422);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(321, 22);
            this.simpleButton2.StyleController = this.frmSetuplayoutControl1ConvertedLayout;
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Cancelar";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleButton2item,
            this.simpleButton1item,
            this.tabPane1item,
            this.panelControl2item});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(670, 456);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleButton2item
            // 
            this.simpleButton2item.Control = this.simpleButton2;
            this.simpleButton2item.Location = new System.Drawing.Point(325, 410);
            this.simpleButton2item.Name = "simpleButton2item";
            this.simpleButton2item.Size = new System.Drawing.Size(325, 26);
            this.simpleButton2item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton2item.TextVisible = false;
            // 
            // simpleButton1item
            // 
            this.simpleButton1item.Control = this.simpleButton1;
            this.simpleButton1item.Location = new System.Drawing.Point(0, 410);
            this.simpleButton1item.Name = "simpleButton1item";
            this.simpleButton1item.Size = new System.Drawing.Size(325, 26);
            this.simpleButton1item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton1item.TextVisible = false;
            // 
            // tabPane1item
            // 
            this.tabPane1item.Control = this.tabPane1;
            this.tabPane1item.Location = new System.Drawing.Point(0, 47);
            this.tabPane1item.Name = "tabPane1item";
            this.tabPane1item.Size = new System.Drawing.Size(650, 363);
            this.tabPane1item.TextSize = new System.Drawing.Size(0, 0);
            this.tabPane1item.TextVisible = false;
            // 
            // panelControl2item
            // 
            this.panelControl2item.Control = this.panelControl2;
            this.panelControl2item.Location = new System.Drawing.Point(0, 0);
            this.panelControl2item.MaxSize = new System.Drawing.Size(0, 47);
            this.panelControl2item.MinSize = new System.Drawing.Size(5, 47);
            this.panelControl2item.Name = "panelControl2item";
            this.panelControl2item.Size = new System.Drawing.Size(650, 47);
            this.panelControl2item.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.panelControl2item.TextSize = new System.Drawing.Size(0, 0);
            this.panelControl2item.TextVisible = false;
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmSetuplayoutControl1ConvertedLayout);
            this.Name = "frmSetup";
            this.Size = new System.Drawing.Size(670, 456);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmSetuplayoutControl1ConvertedLayout)).EndInit();
            this.frmSetuplayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControl frmSetuplayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton2item;
        private DevExpress.XtraLayout.LayoutControlItem simpleButton1item;
        private DevExpress.XtraLayout.LayoutControlItem tabPane1item;
        private DevExpress.XtraLayout.LayoutControlItem panelControl2item;
    }
}
