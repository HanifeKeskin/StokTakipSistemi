namespace StokTakip1.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileAdmin = new DevExpress.XtraEditors.TileItem();
            this.tileSatisSorumlusu = new DevExpress.XtraEditors.TileItem();
            this.tileItem3tileDepartmanSorumlusu = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileControl1.BackgroundImage")));
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 6;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.SelectionColor = System.Drawing.Color.Transparent;
            this.tileControl1.Size = new System.Drawing.Size(576, 329);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileAdmin);
            this.tileGroup2.Name = "tileGroup2";
            this.tileGroup2.Text = "ADMIN";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileSatisSorumlusu);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tileItem3tileDepartmanSorumlusu);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // tileAdmin
            // 
            this.tileAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileAdmin.BackgroundImage")));
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "ADMIN";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileAdmin.Elements.Add(tileItemElement1);
            this.tileAdmin.Id = 3;
            this.tileAdmin.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileAdmin.Name = "tileAdmin";
            this.tileAdmin.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnAdminItemClick);
            // 
            // tileSatisSorumlusu
            // 
            this.tileSatisSorumlusu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileSatisSorumlusu.BackgroundImage")));
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "SATIS SORUMLUSU";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileSatisSorumlusu.Elements.Add(tileItemElement2);
            this.tileSatisSorumlusu.Id = 4;
            this.tileSatisSorumlusu.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileSatisSorumlusu.Name = "tileSatisSorumlusu";
            this.tileSatisSorumlusu.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnSatisSorumlusu_ItemClick);
            // 
            // tileItem3tileDepartmanSorumlusu
            // 
            this.tileItem3tileDepartmanSorumlusu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItem3tileDepartmanSorumlusu.BackgroundImage")));
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "DEPARTMAN SORUMLUSU";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem3tileDepartmanSorumlusu.Elements.Add(tileItemElement3);
            this.tileItem3tileDepartmanSorumlusu.Id = 5;
            this.tileItem3tileDepartmanSorumlusu.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3tileDepartmanSorumlusu.Name = "tileItem3tileDepartmanSorumlusu";
            this.tileItem3tileDepartmanSorumlusu.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnDepartmanSorumlusu_ItemClick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 329);
            this.Controls.Add(this.tileControl1);
            this.Name = "frmLogin";
            this.Text = "LOGIN";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileAdmin;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileSatisSorumlusu;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem tileItem3tileDepartmanSorumlusu;
    }
}