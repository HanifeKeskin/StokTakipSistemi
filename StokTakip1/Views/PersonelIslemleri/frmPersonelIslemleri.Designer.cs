namespace StokTakip1.Views.PersonelIslemleri
{
    partial class frmPersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslemleri));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tileCntrlPersonelIslemleri = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.btnPersonelleriListele = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.btn_KullaniciEkle = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileCntrlPersonelIslemleri
            // 
            this.tileCntrlPersonelIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileCntrlPersonelIslemleri.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileCntrlPersonelIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileCntrlPersonelIslemleri.Groups.Add(this.tileGroup2);
            this.tileCntrlPersonelIslemleri.Groups.Add(this.tileGroup3);
            this.tileCntrlPersonelIslemleri.Location = new System.Drawing.Point(0, 0);
            this.tileCntrlPersonelIslemleri.MaxId = 2;
            this.tileCntrlPersonelIslemleri.Name = "tileCntrlPersonelIslemleri";
            this.tileCntrlPersonelIslemleri.Size = new System.Drawing.Size(450, 295);
            this.tileCntrlPersonelIslemleri.TabIndex = 0;
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.btnPersonelleriListele);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // btnPersonelleriListele
            // 
            this.btnPersonelleriListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelleriListele.BackgroundImage")));
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Personelleri Listele";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btnPersonelleriListele.Elements.Add(tileItemElement1);
            this.btnPersonelleriListele.Id = 0;
            this.btnPersonelleriListele.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btnPersonelleriListele.Name = "btnPersonelleriListele";
            this.btnPersonelleriListele.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnPersonelleriListele_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.btn_KullaniciEkle);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // btn_KullaniciEkle
            // 
            this.btn_KullaniciEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_KullaniciEkle.BackgroundImage")));
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Kullanıcı Ekle";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_KullaniciEkle.Elements.Add(tileItemElement2);
            this.btn_KullaniciEkle.Id = 1;
            this.btn_KullaniciEkle.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_KullaniciEkle.Name = "btn_KullaniciEkle";
            this.btn_KullaniciEkle.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_KullaniciEkle_ItemClick);
            // 
            // frmPersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 295);
            this.Controls.Add(this.tileCntrlPersonelIslemleri);
            this.Name = "frmPersonelIslemleri";
            this.Text = "Personel Islemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPersonelIslemleri_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileCntrlPersonelIslemleri;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem btnPersonelleriListele;
        private DevExpress.XtraEditors.TileItem btn_KullaniciEkle;
    }
}