namespace StokTakip1.Views.UserLogins
{
    partial class frmDepartmanSorumlusuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanSorumlusuLogin));
            this.picDepartmanSGiris = new DevExpress.XtraEditors.PictureEdit();
            this.btnDepartmanSorumlusuGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblDSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblDKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartmanSGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picDepartmanSGiris
            // 
            this.picDepartmanSGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.picDepartmanSGiris.EditValue = ((object)(resources.GetObject("picDepartmanSGiris.EditValue")));
            this.picDepartmanSGiris.Location = new System.Drawing.Point(108, 39);
            this.picDepartmanSGiris.Name = "picDepartmanSGiris";
            this.picDepartmanSGiris.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picDepartmanSGiris.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picDepartmanSGiris.Size = new System.Drawing.Size(191, 93);
            this.picDepartmanSGiris.TabIndex = 17;
            // 
            // btnDepartmanSorumlusuGiris
            // 
            this.btnDepartmanSorumlusuGiris.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanSorumlusuGiris.Appearance.Options.UseFont = true;
            this.btnDepartmanSorumlusuGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnDepartmanSorumlusuGiris.Location = new System.Drawing.Point(162, 265);
            this.btnDepartmanSorumlusuGiris.Name = "btnDepartmanSorumlusuGiris";
            this.btnDepartmanSorumlusuGiris.Size = new System.Drawing.Size(183, 48);
            this.btnDepartmanSorumlusuGiris.TabIndex = 16;
            this.btnDepartmanSorumlusuGiris.Text = "GİRİŞ YAP";
            this.btnDepartmanSorumlusuGiris.Click += new System.EventHandler(this.btnDepartmanSorumlusuGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(162, 212);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.MaxLength = 8;
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(183, 20);
            this.txtSifre.TabIndex = 15;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(162, 175);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.MaxLength = 8;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(183, 20);
            this.txtKullaniciAdi.TabIndex = 14;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // lblDSifre
            // 
            this.lblDSifre.Location = new System.Drawing.Point(42, 219);
            this.lblDSifre.Name = "lblDSifre";
            this.lblDSifre.Size = new System.Drawing.Size(22, 13);
            this.lblDSifre.TabIndex = 13;
            this.lblDSifre.Text = "Sifre";
            // 
            // lblDKullaniciAdi
            // 
            this.lblDKullaniciAdi.Location = new System.Drawing.Point(42, 175);
            this.lblDKullaniciAdi.Name = "lblDKullaniciAdi";
            this.lblDKullaniciAdi.Size = new System.Drawing.Size(51, 13);
            this.lblDKullaniciAdi.TabIndex = 12;
            this.lblDKullaniciAdi.Text = "Kullanıcı ID";
            // 
            // frmDepartmanSorumlusuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::StokTakip1.Properties.Resources.Elegant_Background_3_1200x675;
            this.ClientSize = new System.Drawing.Size(387, 351);
            this.Controls.Add(this.picDepartmanSGiris);
            this.Controls.Add(this.btnDepartmanSorumlusuGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblDSifre);
            this.Controls.Add(this.lblDKullaniciAdi);
            this.Name = "frmDepartmanSorumlusuLogin";
            this.Text = "Departman Sorumlusu Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDepartmanSorumlusuLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picDepartmanSGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picDepartmanSGiris;
        private DevExpress.XtraEditors.SimpleButton btnDepartmanSorumlusuGiris;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblDSifre;
        private DevExpress.XtraEditors.LabelControl lblDKullaniciAdi;
    }
}