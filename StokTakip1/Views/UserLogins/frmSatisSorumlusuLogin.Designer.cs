namespace StokTakip1.Views.UserLogins
{
    partial class frmSatisSorumlusuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisSorumlusuLogin));
            this.picSatisSGiris = new DevExpress.XtraEditors.PictureEdit();
            this.btnSatisSorumlusuGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblSSifre = new DevExpress.XtraEditors.LabelControl();
            this.lblSKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picSatisSGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picSatisSGiris
            // 
            this.picSatisSGiris.Cursor = System.Windows.Forms.Cursors.Default;
            this.picSatisSGiris.EditValue = ((object)(resources.GetObject("picSatisSGiris.EditValue")));
            this.picSatisSGiris.Location = new System.Drawing.Point(105, 41);
            this.picSatisSGiris.Name = "picSatisSGiris";
            this.picSatisSGiris.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picSatisSGiris.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picSatisSGiris.Size = new System.Drawing.Size(192, 93);
            this.picSatisSGiris.TabIndex = 11;
            // 
            // btnSatisSorumlusuGiris
            // 
            this.btnSatisSorumlusuGiris.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisSorumlusuGiris.Appearance.Options.UseFont = true;
            this.btnSatisSorumlusuGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSatisSorumlusuGiris.Location = new System.Drawing.Point(161, 277);
            this.btnSatisSorumlusuGiris.Name = "btnSatisSorumlusuGiris";
            this.btnSatisSorumlusuGiris.Size = new System.Drawing.Size(183, 48);
            this.btnSatisSorumlusuGiris.TabIndex = 10;
            this.btnSatisSorumlusuGiris.Text = "GİRİŞ YAP";
            this.btnSatisSorumlusuGiris.Click += new System.EventHandler(this.btnSatisSorumlusuGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(161, 224);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.MaxLength = 8;
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(183, 20);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(161, 187);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.MaxLength = 8;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(183, 20);
            this.txtKullaniciAdi.TabIndex = 8;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // lblSSifre
            // 
            this.lblSSifre.Location = new System.Drawing.Point(41, 231);
            this.lblSSifre.Name = "lblSSifre";
            this.lblSSifre.Size = new System.Drawing.Size(22, 13);
            this.lblSSifre.TabIndex = 7;
            this.lblSSifre.Text = "Sifre";
            // 
            // lblSKullaniciAdi
            // 
            this.lblSKullaniciAdi.Location = new System.Drawing.Point(41, 187);
            this.lblSKullaniciAdi.Name = "lblSKullaniciAdi";
            this.lblSKullaniciAdi.Size = new System.Drawing.Size(51, 13);
            this.lblSKullaniciAdi.TabIndex = 6;
            this.lblSKullaniciAdi.Text = "Kullanıcı ID";
            // 
            // frmSatisSorumlusuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::StokTakip1.Properties.Resources.Elegant_Background_3_1200x675;
            this.ClientSize = new System.Drawing.Size(388, 351);
            this.Controls.Add(this.picSatisSGiris);
            this.Controls.Add(this.btnSatisSorumlusuGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSSifre);
            this.Controls.Add(this.lblSKullaniciAdi);
            this.Name = "frmSatisSorumlusuLogin";
            this.Text = "Satiş Sorumlusu Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSatisSorumlusu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picSatisSGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picSatisSGiris;
        private DevExpress.XtraEditors.SimpleButton btnSatisSorumlusuGiris;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblSSifre;
        private DevExpress.XtraEditors.LabelControl lblSKullaniciAdi;
    }
}