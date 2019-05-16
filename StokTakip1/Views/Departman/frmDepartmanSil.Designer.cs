namespace StokTakip1.Views.Departman
{
    partial class frmDepartmanSil
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_DepartmanSil = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Sirket = new System.Windows.Forms.ComboBox();
            this.cmb_Holding = new System.Windows.Forms.ComboBox();
            this.lblSirket = new System.Windows.Forms.Label();
            this.txt_DepartmanAdi = new System.Windows.Forms.TextBox();
            this.lblHolding = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(432, 52);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Departman Sil";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_DepartmanSil);
            this.groupControl1.Controls.Add(this.cmb_Sirket);
            this.groupControl1.Controls.Add(this.cmb_Holding);
            this.groupControl1.Controls.Add(this.lblSirket);
            this.groupControl1.Controls.Add(this.txt_DepartmanAdi);
            this.groupControl1.Controls.Add(this.lblHolding);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 52);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(432, 270);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "DepartmanSil";
            // 
            // btn_DepartmanSil
            // 
            this.btn_DepartmanSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_DepartmanSil.Location = new System.Drawing.Point(188, 179);
            this.btn_DepartmanSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DepartmanSil.Name = "btn_DepartmanSil";
            this.btn_DepartmanSil.Size = new System.Drawing.Size(155, 32);
            this.btn_DepartmanSil.TabIndex = 24;
            this.btn_DepartmanSil.Text = "Departman Sil";
            this.btn_DepartmanSil.Click += new System.EventHandler(this.btn_DepartmanSil_Click);
            // 
            // cmb_Sirket
            // 
            this.cmb_Sirket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sirket.FormattingEnabled = true;
            this.cmb_Sirket.Location = new System.Drawing.Point(188, 137);
            this.cmb_Sirket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Sirket.Name = "cmb_Sirket";
            this.cmb_Sirket.Size = new System.Drawing.Size(156, 21);
            this.cmb_Sirket.TabIndex = 22;
            // 
            // cmb_Holding
            // 
            this.cmb_Holding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Holding.FormattingEnabled = true;
            this.cmb_Holding.Location = new System.Drawing.Point(188, 101);
            this.cmb_Holding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Holding.Name = "cmb_Holding";
            this.cmb_Holding.Size = new System.Drawing.Size(156, 21);
            this.cmb_Holding.TabIndex = 23;
            this.cmb_Holding.SelectedIndexChanged += new System.EventHandler(this.cmb_Holding_SelectedIndexChanged);
            // 
            // lblSirket
            // 
            this.lblSirket.AutoSize = true;
            this.lblSirket.Location = new System.Drawing.Point(88, 140);
            this.lblSirket.Name = "lblSirket";
            this.lblSirket.Size = new System.Drawing.Size(38, 13);
            this.lblSirket.TabIndex = 18;
            this.lblSirket.Text = "Sirket:";
            // 
            // txt_DepartmanAdi
            // 
            this.txt_DepartmanAdi.Location = new System.Drawing.Point(188, 60);
            this.txt_DepartmanAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DepartmanAdi.Name = "txt_DepartmanAdi";
            this.txt_DepartmanAdi.Size = new System.Drawing.Size(156, 21);
            this.txt_DepartmanAdi.TabIndex = 21;
            this.txt_DepartmanAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DepartmanAdi_KeyPress);
            // 
            // lblHolding
            // 
            this.lblHolding.AutoSize = true;
            this.lblHolding.Location = new System.Drawing.Point(88, 101);
            this.lblHolding.Name = "lblHolding";
            this.lblHolding.Size = new System.Drawing.Size(46, 13);
            this.lblHolding.TabIndex = 19;
            this.lblHolding.Text = "Holding:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(88, 63);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(78, 13);
            this.lblAd.TabIndex = 20;
            this.lblAd.Text = "Departman ID:";
            // 
            // frmDepartmanSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 322);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmDepartmanSil";
            this.Text = "DepartmanSil";
            this.Load += new System.EventHandler(this.frmDepartmanSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DepartmanSil;
        private System.Windows.Forms.ComboBox cmb_Sirket;
        private System.Windows.Forms.ComboBox cmb_Holding;
        private System.Windows.Forms.Label lblSirket;
        private System.Windows.Forms.TextBox txt_DepartmanAdi;
        private System.Windows.Forms.Label lblHolding;
        private System.Windows.Forms.Label lblAd;
    }
}