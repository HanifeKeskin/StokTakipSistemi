namespace StokTakip1.Views
{
    partial class frmDepartmanSorumlusu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmanSorumlusu));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tilePersonelListele = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.btn_Personeller = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tilePersonelListele);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 5;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(483, 284);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tilePersonelListele
            // 
            this.tilePersonelListele.Items.Add(this.btn_Personeller);
            this.tilePersonelListele.Name = "tilePersonelListele";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // btn_Personeller
            // 
            this.btn_Personeller.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Personeller.BackgroundImage")));
            tileItemElement1.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement1.Image")));
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Personeller";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btn_Personeller.Elements.Add(tileItemElement1);
            this.btn_Personeller.Id = 0;
            this.btn_Personeller.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.btn_Personeller.Name = "btn_Personeller";
            this.btn_Personeller.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.btn_Personeller.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_Personeller_ItemClick);
            // 
            // tileItem1
            // 
            this.tileItem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItem1.BackgroundImage")));
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "CIKIS";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem1.Elements.Add(tileItemElement2);
            this.tileItem1.Id = 4;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // frmDepartmanSorumlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 284);
            this.Controls.Add(this.tileControl1);
            this.Name = "frmDepartmanSorumlusu";
            this.Text = "DepartmanSorumlusu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDepartmanSorumlusu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tilePersonelListele;
        private DevExpress.XtraEditors.TileItem btn_Personeller;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
    }
}