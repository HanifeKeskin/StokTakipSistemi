namespace StokTakip1.Views.UserLogins
{
    partial class frmAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminLogin));
            this.lblAKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblASifre = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnAdminGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAKullaniciAdi
            // 
            this.lblAKullaniciAdi.Location = new System.Drawing.Point(42, 172);
            this.lblAKullaniciAdi.Name = "lblAKullaniciAdi";
            this.lblAKullaniciAdi.Size = new System.Drawing.Size(51, 13);
            this.lblAKullaniciAdi.TabIndex = 0;
            this.lblAKullaniciAdi.Text = "Kullanıcı ID";
            // 
            // lblASifre
            // 
            this.lblASifre.Location = new System.Drawing.Point(42, 216);
            this.lblASifre.Name = "lblASifre";
            this.lblASifre.Size = new System.Drawing.Size(22, 13);
            this.lblASifre.TabIndex = 1;
            this.lblASifre.Text = "Sifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(162, 172);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.MaxLength = 8;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(183, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(162, 209);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.MaxLength = 8;
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(183, 20);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Appearance.Options.UseFont = true;
            this.btnAdminGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnAdminGiris.Location = new System.Drawing.Point(162, 262);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(183, 48);
            this.btnAdminGiris.TabIndex = 4;
            this.btnAdminGiris.Text = "GİRİŞ YAP";
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.BackgroundImage")));
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(107, 34);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(192, 93);
            this.pictureEdit1.TabIndex = 5;
            // 
            // frmAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(389, 348);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblASifre);
            this.Controls.Add(this.lblAKullaniciAdi);
            this.Name = "frmAdminLogin";
            this.Text = "Admin Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblASifre;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnAdminGiris;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}