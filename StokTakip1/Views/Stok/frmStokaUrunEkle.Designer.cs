namespace StokTakip1.Views.Stok
{
    partial class frmStokaUrunEkle
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
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.grpControlStokUrunEkle = new DevExpress.XtraEditors.GroupControl();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.btn_UrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.cmb_UrunKategori = new System.Windows.Forms.ComboBox();
            this.txt_urunAdet = new System.Windows.Forms.TextBox();
            this.txt_UrunBirimFiyat = new System.Windows.Forms.TextBox();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlStokUrunEkle)).BeginInit();
            this.grpControlStokUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(589, 79);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ürün ekle";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 509);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(589, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // grpControlStokUrunEkle
            // 
            this.grpControlStokUrunEkle.Controls.Add(this.lblEklenmeTarihi);
            this.grpControlStokUrunEkle.Controls.Add(this.label3);
            this.grpControlStokUrunEkle.Controls.Add(this.label2);
            this.grpControlStokUrunEkle.Controls.Add(this.label1);
            this.grpControlStokUrunEkle.Controls.Add(this.lblUrunAdi);
            this.grpControlStokUrunEkle.Controls.Add(this.btn_UrunEkle);
            this.grpControlStokUrunEkle.Controls.Add(this.calendarControl1);
            this.grpControlStokUrunEkle.Controls.Add(this.cmb_UrunKategori);
            this.grpControlStokUrunEkle.Controls.Add(this.txt_urunAdet);
            this.grpControlStokUrunEkle.Controls.Add(this.txt_UrunBirimFiyat);
            this.grpControlStokUrunEkle.Controls.Add(this.txt_UrunAdi);
            this.grpControlStokUrunEkle.Location = new System.Drawing.Point(93, 85);
            this.grpControlStokUrunEkle.Name = "grpControlStokUrunEkle";
            this.grpControlStokUrunEkle.Size = new System.Drawing.Size(382, 418);
            this.grpControlStokUrunEkle.TabIndex = 2;
            this.grpControlStokUrunEkle.Text = "Stoğa Ürün Ekle";
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(19, 137);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(83, 13);
            this.lblEklenmeTarihi.TabIndex = 11;
            this.lblEklenmeTarihi.Text = "ALINMA TARİHİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ÜRÜN ADEDİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ÜRÜN BİRİM FİYATI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "URUN KATEGORİSİ";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(16, 31);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(56, 13);
            this.lblUrunAdi.TabIndex = 7;
            this.lblUrunAdi.Text = "ÜRÜN ADI";
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Location = new System.Drawing.Point(145, 370);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(230, 43);
            this.btn_UrunEkle.TabIndex = 6;
            this.btn_UrunEkle.Text = "ÜRÜN EKLE";
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(145, 137);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(229, 227);
            this.calendarControl1.TabIndex = 5;
            // 
            // cmb_UrunKategori
            // 
            this.cmb_UrunKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UrunKategori.FormattingEnabled = true;
            this.cmb_UrunKategori.Location = new System.Drawing.Point(145, 50);
            this.cmb_UrunKategori.Name = "cmb_UrunKategori";
            this.cmb_UrunKategori.Size = new System.Drawing.Size(230, 21);
            this.cmb_UrunKategori.TabIndex = 4;
            // 
            // txt_urunAdet
            // 
            this.txt_urunAdet.Location = new System.Drawing.Point(145, 104);
            this.txt_urunAdet.MaxLength = 10;
            this.txt_urunAdet.Name = "txt_urunAdet";
            this.txt_urunAdet.Size = new System.Drawing.Size(230, 21);
            this.txt_urunAdet.TabIndex = 2;
            this.txt_urunAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_urunAdet_KeyPress);
            // 
            // txt_UrunBirimFiyat
            // 
            this.txt_UrunBirimFiyat.Location = new System.Drawing.Point(145, 77);
            this.txt_UrunBirimFiyat.MaxLength = 25;
            this.txt_UrunBirimFiyat.Name = "txt_UrunBirimFiyat";
            this.txt_UrunBirimFiyat.Size = new System.Drawing.Size(230, 21);
            this.txt_UrunBirimFiyat.TabIndex = 1;
            this.txt_UrunBirimFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UrunBirimFiyat_KeyPress);
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(145, 23);
            this.txt_UrunAdi.MaxLength = 25;
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(230, 21);
            this.txt_UrunAdi.TabIndex = 0;
            this.txt_UrunAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UrunAdi_KeyPress);
            // 
            // frmStokaUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 540);
            this.Controls.Add(this.grpControlStokUrunEkle);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmStokaUrunEkle";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Stoğa Ürün Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStokaUrunEkle_FormClosed);
            this.Load += new System.EventHandler(this.frmStokaUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlStokUrunEkle)).EndInit();
            this.grpControlStokUrunEkle.ResumeLayout(false);
            this.grpControlStokUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.GroupControl grpControlStokUrunEkle;
        private System.Windows.Forms.TextBox txt_urunAdet;
        private System.Windows.Forms.TextBox txt_UrunBirimFiyat;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.ComboBox cmb_UrunKategori;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraEditors.SimpleButton btn_UrunEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblEklenmeTarihi;
    }
}