namespace StokTakip1.Views
{
    partial class frmSatisSorumlusu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisSorumlusu));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.btn_PersonelleriListele = new DevExpress.XtraEditors.TileItem();
            this.btn_DepartmanEkle = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.btn_StokIslemleri = new DevExpress.XtraEditors.TileItem();
            this.bnt_DemirbasIslemleri = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.btn_Cikis = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 5;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(779, 322);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.btn_PersonelleriListele);
            this.tileGroup2.Items.Add(this.btn_DepartmanEkle);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // btn_PersonelleriListele
            // 
            this.btn_PersonelleriListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PersonelleriListele.BackgroundImage")));
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Personelleri listele";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_PersonelleriListele.Elements.Add(tileItemElement1);
            this.btn_PersonelleriListele.Id = 0;
            this.btn_PersonelleriListele.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_PersonelleriListele.Name = "btn_PersonelleriListele";
            this.btn_PersonelleriListele.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_PersonelleriListele_ItemClick);
            // 
            // btn_DepartmanEkle
            // 
            this.btn_DepartmanEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DepartmanEkle.BackgroundImage")));
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Departman Ekle";
            this.btn_DepartmanEkle.Elements.Add(tileItemElement2);
            this.btn_DepartmanEkle.Id = 2;
            this.btn_DepartmanEkle.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_DepartmanEkle.Name = "btn_DepartmanEkle";
            this.btn_DepartmanEkle.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_DepartmanEkle_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.btn_StokIslemleri);
            this.tileGroup3.Items.Add(this.bnt_DemirbasIslemleri);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // btn_StokIslemleri
            // 
            this.btn_StokIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StokIslemleri.BackgroundImage")));
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Stok Islemleri";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_StokIslemleri.Elements.Add(tileItemElement3);
            this.btn_StokIslemleri.Id = 1;
            this.btn_StokIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_StokIslemleri.Name = "btn_StokIslemleri";
            this.btn_StokIslemleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_StokIslemleri_ItemClick);
            // 
            // bnt_DemirbasIslemleri
            // 
            this.bnt_DemirbasIslemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnt_DemirbasIslemleri.BackgroundImage")));
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement4.Text = "Demirbas Islemleri";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.bnt_DemirbasIslemleri.Elements.Add(tileItemElement4);
            this.bnt_DemirbasIslemleri.Id = 3;
            this.bnt_DemirbasIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.bnt_DemirbasIslemleri.Name = "bnt_DemirbasIslemleri";
            this.bnt_DemirbasIslemleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.bnt_DemirbasIslemleri_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.btn_Cikis);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cikis.BackgroundImage")));
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement5.Text = "ÇIKIŞ";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_Cikis.Elements.Add(tileItemElement5);
            this.btn_Cikis.Id = 4;
            this.btn_Cikis.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_Cikis_ItemClick);
            // 
            // frmSatisSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 322);
            this.Controls.Add(this.tileControl1);
            this.Name = "frmSatisSorumlusu";
            this.Text = "SatisSorumlusu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSatisSorumlusu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem btn_PersonelleriListele;
        private DevExpress.XtraEditors.TileItem btn_DepartmanEkle;
        private DevExpress.XtraEditors.TileItem btn_StokIslemleri;
        private DevExpress.XtraEditors.TileItem bnt_DemirbasIslemleri;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem btn_Cikis;
    }
}