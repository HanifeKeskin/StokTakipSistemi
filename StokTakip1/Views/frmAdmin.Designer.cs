namespace StokTakip1.Views
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.tlControlAdmin = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.btn_PersonelIslemleri = new DevExpress.XtraEditors.TileItem();
            this.btn_ZimmetIslemleri = new DevExpress.XtraEditors.TileItem();
            this.btn_DepartmanEkle = new DevExpress.XtraEditors.TileItem();
            this.btn_DepartmanSil = new DevExpress.XtraEditors.TileItem();
            this.btn_StokIslemleri = new DevExpress.XtraEditors.TileItem();
            this.btn_DemirbasIslemleri = new DevExpress.XtraEditors.TileItem();
            this.btn_Raporlar = new DevExpress.XtraEditors.TileItem();
            this.btn_Cikis = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tlControlAdmin
            // 
            this.tlControlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tlControlAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlControlAdmin.Groups.Add(this.tileGroup2);
            this.tlControlAdmin.Groups.Add(this.tileGroup3);
            this.tlControlAdmin.Groups.Add(this.tileGroup4);
            this.tlControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tlControlAdmin.MaxId = 12;
            this.tlControlAdmin.Name = "tlControlAdmin";
            this.tlControlAdmin.Size = new System.Drawing.Size(889, 510);
            this.tlControlAdmin.TabIndex = 0;
            this.tlControlAdmin.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.btn_PersonelIslemleri);
            this.tileGroup2.Items.Add(this.btn_ZimmetIslemleri);
            this.tileGroup2.Items.Add(this.btn_DepartmanEkle);
            this.tileGroup2.Items.Add(this.btn_DepartmanSil);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.btn_StokIslemleri);
            this.tileGroup3.Items.Add(this.btn_DemirbasIslemleri);
            this.tileGroup3.Items.Add(this.btn_Raporlar);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.btn_Cikis);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // btn_PersonelIslemleri
            // 
            this.btn_PersonelIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PersonelIslemleri.BackgroundImage")));
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Personel İşlemleri";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_PersonelIslemleri.Elements.Add(tileItemElement1);
            this.btn_PersonelIslemleri.Id = 0;
            this.btn_PersonelIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_PersonelIslemleri.Name = "btn_PersonelIslemleri";
            this.btn_PersonelIslemleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_PersonelIslemleri_ItemClick);
            // 
            // btn_ZimmetIslemleri
            // 
            this.btn_ZimmetIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ZimmetIslemleri.BackgroundImage")));
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Zimmet İşlemleri";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_ZimmetIslemleri.Elements.Add(tileItemElement2);
            this.btn_ZimmetIslemleri.Id = 7;
            this.btn_ZimmetIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_ZimmetIslemleri.Name = "btn_ZimmetIslemleri";
            this.btn_ZimmetIslemleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_ZimmetIslemleri_ItemClick);
            // 
            // btn_DepartmanEkle
            // 
            this.btn_DepartmanEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanEkle.BackgroundImage")));
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Departman Ekle";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_DepartmanEkle.Elements.Add(tileItemElement3);
            this.btn_DepartmanEkle.Id = 8;
            this.btn_DepartmanEkle.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_DepartmanEkle.Name = "btn_DepartmanEkle";
            this.btn_DepartmanEkle.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_DepartmanEkle_ItemClick);
            // 
            // btn_DepartmanSil
            // 
            this.btn_DepartmanSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanSil.BackgroundImage")));
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "Departman Sil";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_DepartmanSil.Elements.Add(tileItemElement4);
            this.btn_DepartmanSil.Id = 11;
            this.btn_DepartmanSil.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_DepartmanSil.Name = "btn_DepartmanSil";
            this.btn_DepartmanSil.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_DepartmanSil_ItemClick);
            // 
            // btn_StokIslemleri
            // 
            this.btn_StokIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StokIslemleri.BackgroundImage")));
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement5.Text = "Stok İşlemleri";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_StokIslemleri.Elements.Add(tileItemElement5);
            this.btn_StokIslemleri.Id = 1;
            this.btn_StokIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_StokIslemleri.Name = "btn_StokIslemleri";
            this.btn_StokIslemleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_StokIslemleri_ItemClick);
            // 
            // btn_DemirbasIslemleri
            // 
            this.btn_DemirbasIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DemirbasIslemleri.BackgroundImage")));
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement6.Text = "Demirbaş İşlemleri";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_DemirbasIslemleri.Elements.Add(tileItemElement6);
            this.btn_DemirbasIslemleri.Id = 3;
            this.btn_DemirbasIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_DemirbasIslemleri.Name = "btn_DemirbasIslemleri";
            this.btn_DemirbasIslemleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_DemirbasIslemleri_ItemClick);
            // 
            // btn_Raporlar
            // 
            this.btn_Raporlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Raporlar.BackgroundImage")));
            tileItemElement7.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement7.Image")));
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement7.Text = "Raporlar";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_Raporlar.Elements.Add(tileItemElement7);
            this.btn_Raporlar.Id = 6;
            this.btn_Raporlar.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.btn_Raporlar.Name = "btn_Raporlar";
            this.btn_Raporlar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_Raporlar_ItemClick);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cikis.BackgroundImage")));
            tileItemElement8.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement8.Image")));
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement8.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement8.Text = "ÇIKIŞ";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_Cikis.Elements.Add(tileItemElement8);
            this.btn_Cikis.Id = 10;
            this.btn_Cikis.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_Cikis_ItemClick);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 510);
            this.Controls.Add(this.tlControlAdmin);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tlControlAdmin;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem btn_PersonelIslemleri;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem btn_ZimmetIslemleri;
        private DevExpress.XtraEditors.TileItem btn_DepartmanEkle;
        private DevExpress.XtraEditors.TileItem btn_StokIslemleri;
        private DevExpress.XtraEditors.TileItem btn_DemirbasIslemleri;
        private DevExpress.XtraEditors.TileItem btn_Raporlar;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem btn_Cikis;
        private DevExpress.XtraEditors.TileItem btn_DepartmanSil;
    }
}