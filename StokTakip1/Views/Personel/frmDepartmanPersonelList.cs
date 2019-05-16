using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using StokTakip1.Controller;
using StokTakip1.Model;
using StokTakip1.Views;

namespace StokTakip1.Views.Personel
{
    public partial class frmDepartmanPersonelList : XtraForm
    {
        public frmDepartmanPersonelList()
        {
            InitializeComponent();
        }

        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Print") grid_Personel.ShowRibbonPrintPreview();
        }
        
        private void frmDepartmanPersonelList_Load(object sender, EventArgs e)
        {
            var result = PersonellerController.KullanicilariListele();
            DataTable dtKullancilar = new DataTable("personeller");
            dtKullancilar.Columns.Add("Ad", typeof(string));
            dtKullancilar.Columns.Add("Soyad", typeof(string));
            dtKullancilar.Columns.Add("KisiId", typeof(int));
            dtKullancilar.Columns.Add("Departman", typeof(string));
            dtKullancilar.Columns.Add("Zimmet", typeof(string));
            foreach (var item in result)
            {
                dtKullancilar.Rows.Add(item.Ad, item.Soyad, item.KisiId);
                var result2 = PersonellerController.KullaniciSorumluDepartmanlar(item.KisiId);
                /*foreach(var item2 in result2)
                {
                    dtKullancilar.Rows.Add(item2.Departman, item2.Zimmet);
                }*/
                
            }
            grid_Personel.DataSource = dtKullancilar;

            gridView.Columns["KisiId"].Visible = false;
        }
    }
}
