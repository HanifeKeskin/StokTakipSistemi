namespace StokTakip1.Views.PersonelIslemleri
{
    partial class frmKullaniciEkle
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btn_KullaniciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullaniciId = new System.Windows.Forms.TextBox();
            this.txtKullaniciRolu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(390, 301);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(171, 76);
            this.txtKullaniciAdi.MaxLength = 20;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(192, 21);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(171, 117);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(192, 21);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // btn_KullaniciEkle
            // 
            this.btn_KullaniciEkle.Location = new System.Drawing.Point(171, 215);
            this.btn_KullaniciEkle.Name = "btn_KullaniciEkle";
            this.btn_KullaniciEkle.Size = new System.Drawing.Size(192, 50);
            this.btn_KullaniciEkle.TabIndex = 3;
            this.btn_KullaniciEkle.Text = "KULLANICI EKLE";
            this.btn_KullaniciEkle.Click += new System.EventHandler(this.btn_KullaniciEkle_Click);
            // 
            // txtKullaniciId
            // 
            this.txtKullaniciId.Location = new System.Drawing.Point(171, 36);
            this.txtKullaniciId.MaxLength = 8;
            this.txtKullaniciId.Name = "txtKullaniciId";
            this.txtKullaniciId.Size = new System.Drawing.Size(192, 21);
            this.txtKullaniciId.TabIndex = 4;
            this.txtKullaniciId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciId_KeyPress);
            // 
            // txtKullaniciRolu
            // 
            this.txtKullaniciRolu.Location = new System.Drawing.Point(171, 157);
            this.txtKullaniciRolu.MaxLength = 3;
            this.txtKullaniciRolu.Name = "txtKullaniciRolu";
            this.txtKullaniciRolu.Size = new System.Drawing.Size(192, 21);
            this.txtKullaniciRolu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanici ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanici Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanici Sifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanici Rol";
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 301);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKullaniciRolu);
            this.Controls.Add(this.txtKullaniciId);
            this.Controls.Add(this.btn_KullaniciEkle);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.tileControl1);
            this.Name = "frmKullaniciEkle";
            this.Text = "Kullanici Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKullaniciEkle_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private DevExpress.XtraEditors.SimpleButton btn_KullaniciEkle;
        private System.Windows.Forms.TextBox txtKullaniciId;
        private System.Windows.Forms.TextBox txtKullaniciRolu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}