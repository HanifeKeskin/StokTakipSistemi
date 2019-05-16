namespace StokTakip1.Views.ZimmetIslemleri
{
    partial class frmZimmet
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
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grpControlZimmetleme = new DevExpress.XtraEditors.GroupControl();
            this.lblDepartmanId = new System.Windows.Forms.Label();
            this.txtDepartmanId = new System.Windows.Forms.TextBox();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZimmetlemeTarihi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btn_Zimmetle = new DevExpress.XtraEditors.SimpleButton();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.cmb_UrunKategori = new System.Windows.Forms.ComboBox();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlZimmetleme)).BeginInit();
            this.grpControlZimmetleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Location = new System.Drawing.Point(0, 80);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(516, 411);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
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
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(516, 80);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Zimmetleme";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 491);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(516, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // grpControlZimmetleme
            // 
            this.grpControlZimmetleme.Controls.Add(this.lblDepartmanId);
            this.grpControlZimmetleme.Controls.Add(this.txtDepartmanId);
            this.grpControlZimmetleme.Controls.Add(this.txtPersonelId);
            this.grpControlZimmetleme.Controls.Add(this.label2);
            this.grpControlZimmetleme.Controls.Add(this.lblZimmetlemeTarihi);
            this.grpControlZimmetleme.Controls.Add(this.label1);
            this.grpControlZimmetleme.Controls.Add(this.lblUrunAdi);
            this.grpControlZimmetleme.Controls.Add(this.btn_Zimmetle);
            this.grpControlZimmetleme.Controls.Add(this.calendarControl1);
            this.grpControlZimmetleme.Controls.Add(this.cmb_UrunKategori);
            this.grpControlZimmetleme.Controls.Add(this.txt_UrunAdi);
            this.grpControlZimmetleme.Location = new System.Drawing.Point(69, 85);
            this.grpControlZimmetleme.Name = "grpControlZimmetleme";
            this.grpControlZimmetleme.Size = new System.Drawing.Size(382, 400);
            this.grpControlZimmetleme.TabIndex = 3;
            this.grpControlZimmetleme.Text = "Zimmetleme";
            // 
            // lblDepartmanId
            // 
            this.lblDepartmanId.AutoSize = true;
            this.lblDepartmanId.Location = new System.Drawing.Point(10, 51);
            this.lblDepartmanId.Name = "lblDepartmanId";
            this.lblDepartmanId.Size = new System.Drawing.Size(82, 13);
            this.lblDepartmanId.TabIndex = 15;
            this.lblDepartmanId.Text = "DEPARTMAN ID";
            // 
            // txtDepartmanId
            // 
            this.txtDepartmanId.Location = new System.Drawing.Point(135, 43);
            this.txtDepartmanId.MaxLength = 8;
            this.txtDepartmanId.Name = "txtDepartmanId";
            this.txtDepartmanId.Size = new System.Drawing.Size(230, 21);
            this.txtDepartmanId.TabIndex = 14;
            this.txtDepartmanId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartmanId_KeyPress);
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(135, 16);
            this.txtPersonelId.MaxLength = 8;
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(230, 21);
            this.txtPersonelId.TabIndex = 13;
            this.txtPersonelId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonelId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "PERSONEL ID";
            // 
            // lblZimmetlemeTarihi
            // 
            this.lblZimmetlemeTarihi.AutoSize = true;
            this.lblZimmetlemeTarihi.Location = new System.Drawing.Point(10, 118);
            this.lblZimmetlemeTarihi.Name = "lblZimmetlemeTarihi";
            this.lblZimmetlemeTarihi.Size = new System.Drawing.Size(108, 13);
            this.lblZimmetlemeTarihi.TabIndex = 11;
            this.lblZimmetlemeTarihi.Text = "ZİMMETLEME TARİHİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "URUN KATEGORİSİ";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(10, 73);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(56, 13);
            this.lblUrunAdi.TabIndex = 7;
            this.lblUrunAdi.Text = "ÜRÜN ADI";
            // 
            // btn_Zimmetle
            // 
            this.btn_Zimmetle.Location = new System.Drawing.Point(136, 357);
            this.btn_Zimmetle.Name = "btn_Zimmetle";
            this.btn_Zimmetle.Size = new System.Drawing.Size(230, 43);
            this.btn_Zimmetle.TabIndex = 6;
            this.btn_Zimmetle.Text = "Zimmetle";
            this.btn_Zimmetle.Click += new System.EventHandler(this.btn_Zimmetle_Click);
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(135, 124);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(229, 227);
            this.calendarControl1.TabIndex = 5;
            // 
            // cmb_UrunKategori
            // 
            this.cmb_UrunKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UrunKategori.FormattingEnabled = true;
            this.cmb_UrunKategori.Location = new System.Drawing.Point(136, 97);
            this.cmb_UrunKategori.Name = "cmb_UrunKategori";
            this.cmb_UrunKategori.Size = new System.Drawing.Size(230, 21);
            this.cmb_UrunKategori.TabIndex = 4;
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(136, 70);
            this.txt_UrunAdi.MaxLength = 25;
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(230, 21);
            this.txt_UrunAdi.TabIndex = 0;
            this.txt_UrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UrunAdi_KeyPress);
            // 
            // frmZimmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 522);
            this.Controls.Add(this.grpControlZimmetleme);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmZimmet";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Zimmet";
            this.Load += new System.EventHandler(this.frmZimmet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlZimmetleme)).EndInit();
            this.grpControlZimmetleme.ResumeLayout(false);
            this.grpControlZimmetleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.GroupControl grpControlZimmetleme;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblZimmetlemeTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrunAdi;
        private DevExpress.XtraEditors.SimpleButton btn_Zimmetle;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private System.Windows.Forms.ComboBox cmb_UrunKategori;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.Label lblDepartmanId;
        private System.Windows.Forms.TextBox txtDepartmanId;
    }
}