namespace StokTakip1.Views.Demirbas
{
    partial class frmDemirbasEkle
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
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grp_Demirbas = new DevExpress.XtraEditors.GroupControl();
            this.btn_DemirbasEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Categories = new System.Windows.Forms.ComboBox();
            this.cmb_Departments = new System.Windows.Forms.ComboBox();
            this.cmb_Faculties = new System.Windows.Forms.ComboBox();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_UrunAdi = new System.Windows.Forms.Label();
            this.txt_Adet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_UrunList = new DevExpress.XtraEditors.GroupControl();
            this.grid_Urunler = new DevExpress.XtraGrid.GridControl();
            this.gridView_Urun = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Demirbas)).BeginInit();
            this.grp_Demirbas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_UrunList)).BeginInit();
            this.grp_UrunList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Urun)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(891, 52);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Demirbas Ekle";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // grp_Demirbas
            // 
            this.grp_Demirbas.Controls.Add(this.btn_DemirbasEkle);
            this.grp_Demirbas.Controls.Add(this.cmb_Categories);
            this.grp_Demirbas.Controls.Add(this.cmb_Departments);
            this.grp_Demirbas.Controls.Add(this.cmb_Faculties);
            this.grp_Demirbas.Controls.Add(this.txt_Aciklama);
            this.grp_Demirbas.Controls.Add(this.label4);
            this.grp_Demirbas.Controls.Add(this.lbl_UrunAdi);
            this.grp_Demirbas.Controls.Add(this.txt_Adet);
            this.grp_Demirbas.Controls.Add(this.label6);
            this.grp_Demirbas.Controls.Add(this.label3);
            this.grp_Demirbas.Controls.Add(this.label5);
            this.grp_Demirbas.Controls.Add(this.label2);
            this.grp_Demirbas.Controls.Add(this.label1);
            this.grp_Demirbas.Location = new System.Drawing.Point(12, 57);
            this.grp_Demirbas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_Demirbas.Name = "grp_Demirbas";
            this.grp_Demirbas.Size = new System.Drawing.Size(486, 390);
            this.grp_Demirbas.TabIndex = 5;
            this.grp_Demirbas.Text = "Demirbaş Ekle";
            // 
            // btn_DemirbasEkle
            // 
            this.btn_DemirbasEkle.Location = new System.Drawing.Point(133, 346);
            this.btn_DemirbasEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DemirbasEkle.Name = "btn_DemirbasEkle";
            this.btn_DemirbasEkle.Size = new System.Drawing.Size(344, 36);
            this.btn_DemirbasEkle.TabIndex = 6;
            this.btn_DemirbasEkle.Text = "Demirbaşı Ekle";
            this.btn_DemirbasEkle.Click += new System.EventHandler(this.btn_DemirbasEkle_Click);
            // 
            // cmb_Categories
            // 
            this.cmb_Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Categories.FormattingEnabled = true;
            this.cmb_Categories.Location = new System.Drawing.Point(133, 109);
            this.cmb_Categories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Categories.Name = "cmb_Categories";
            this.cmb_Categories.Size = new System.Drawing.Size(127, 21);
            this.cmb_Categories.TabIndex = 5;
            // 
            // cmb_Departments
            // 
            this.cmb_Departments.DisplayMember = "DepartmentId";
            this.cmb_Departments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Departments.FormattingEnabled = true;
            this.cmb_Departments.Location = new System.Drawing.Point(133, 78);
            this.cmb_Departments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Departments.Name = "cmb_Departments";
            this.cmb_Departments.Size = new System.Drawing.Size(127, 21);
            this.cmb_Departments.TabIndex = 5;
            this.cmb_Departments.ValueMember = "DepartmentId";
            // 
            // cmb_Faculties
            // 
            this.cmb_Faculties.DisplayMember = "FacultyId";
            this.cmb_Faculties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Faculties.FormattingEnabled = true;
            this.cmb_Faculties.Location = new System.Drawing.Point(133, 45);
            this.cmb_Faculties.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Faculties.Name = "cmb_Faculties";
            this.cmb_Faculties.Size = new System.Drawing.Size(127, 21);
            this.cmb_Faculties.TabIndex = 5;
            this.cmb_Faculties.ValueMember = "FacultyId";
            this.cmb_Faculties.SelectedIndexChanged += new System.EventHandler(this.cmb_Faculties_SelectedIndexChanged);
            this.cmb_Faculties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Faculties_KeyDown);
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Location = new System.Drawing.Point(133, 202);
            this.txt_Aciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Aciklama.MaxLength = 100;
            this.txt_Aciklama.Multiline = true;
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(344, 120);
            this.txt_Aciklama.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Demirbaş Açıklaması";
            // 
            // lbl_UrunAdi
            // 
            this.lbl_UrunAdi.AutoSize = true;
            this.lbl_UrunAdi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_UrunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_UrunAdi.Location = new System.Drawing.Point(137, 178);
            this.lbl_UrunAdi.Name = "lbl_UrunAdi";
            this.lbl_UrunAdi.Size = new System.Drawing.Size(0, 17);
            this.lbl_UrunAdi.TabIndex = 3;
            // 
            // txt_Adet
            // 
            this.txt_Adet.Location = new System.Drawing.Point(133, 146);
            this.txt_Adet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Adet.MaxLength = 10;
            this.txt_Adet.Name = "txt_Adet";
            this.txt_Adet.Size = new System.Drawing.Size(127, 21);
            this.txt_Adet.TabIndex = 4;
            this.txt_Adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Adet_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seçilen Ürün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Demirbaş Adedi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sirket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Holding";
            // 
            // grp_UrunList
            // 
            this.grp_UrunList.Controls.Add(this.grid_Urunler);
            this.grp_UrunList.Location = new System.Drawing.Point(504, 57);
            this.grp_UrunList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_UrunList.Name = "grp_UrunList";
            this.grp_UrunList.Size = new System.Drawing.Size(387, 390);
            this.grp_UrunList.TabIndex = 6;
            this.grp_UrunList.Text = "Ürünler";
            // 
            // grid_Urunler
            // 
            this.grid_Urunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Urunler.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_Urunler.Location = new System.Drawing.Point(2, 20);
            this.grid_Urunler.MainView = this.gridView_Urun;
            this.grid_Urunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_Urunler.Name = "grid_Urunler";
            this.grid_Urunler.Size = new System.Drawing.Size(383, 368);
            this.grid_Urunler.TabIndex = 0;
            this.grid_Urunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Urun});
            // 
            // gridView_Urun
            // 
            this.gridView_Urun.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Urun.GridControl = this.grid_Urunler;
            this.gridView_Urun.Name = "gridView_Urun";
            this.gridView_Urun.OptionsBehavior.Editable = false;
            this.gridView_Urun.OptionsBehavior.ReadOnly = true;
            this.gridView_Urun.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Urun_RowClick);
            // 
            // frmDemirbasEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 469);
            this.Controls.Add(this.grp_UrunList);
            this.Controls.Add(this.grp_Demirbas);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmDemirbasEkle";
            this.Text = "Demirbas Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDemirbasEkle_FormClosed);
            this.Load += new System.EventHandler(this.frmDemirbasEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_Demirbas)).EndInit();
            this.grp_Demirbas.ResumeLayout(false);
            this.grp_Demirbas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_UrunList)).EndInit();
            this.grp_UrunList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Urun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl grp_Demirbas;
        private DevExpress.XtraEditors.SimpleButton btn_DemirbasEkle;
        private System.Windows.Forms.ComboBox cmb_Categories;
        private System.Windows.Forms.ComboBox cmb_Departments;
        private System.Windows.Forms.ComboBox cmb_Faculties;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_UrunAdi;
        private System.Windows.Forms.TextBox txt_Adet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl grp_UrunList;
        private DevExpress.XtraGrid.GridControl grid_Urunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Urun;
    }
}