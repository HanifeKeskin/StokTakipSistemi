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
using StokTakip1.Views.Stok;
using StokTakip1.Views.Demirbas;
using StokTakip1.Views.PersonelIslemleri;
using StokTakip1.Views.ZimmetIslemleri;
using StokTakip1.Views.Departman;
using StokTakip1.Views.Raporlar;

namespace StokTakip1.Views
{
    public partial class frmAdmin : DevExpress.XtraEditors.XtraForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btn_StokIslemleri_ItemClick(object sender, TileItemEventArgs e)
        {
            frmStokaUrunEkle SUE = new frmStokaUrunEkle();
            SUE.Show();
            
        }

        private void btn_DemirbasIslemleri_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDemirbasIslemleri DI = new frmDemirbasIslemleri();
            DI.Show();
           
        }

        private void btn_PersonelIslemleri_ItemClick(object sender, TileItemEventArgs e)
        {
            frmPersonelIslemleri PI = new frmPersonelIslemleri();
            PI.Show();
            
        }

        private void btn_ZimmetIslemleri_ItemClick(object sender, TileItemEventArgs e)
        {
            frmZimmet Z = new frmZimmet();
            Z.Show();
            
        }

        private void btn_DepartmanEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepartmanEkle D = new frmDepartmanEkle();
            D.Show();
           
        }

        private void btn_Cikis_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void btn_DepartmanSil_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepartmanSil DS = new frmDepartmanSil();
            DS.Show();
           
        }

        private void btn_Raporlar_ItemClick(object sender, TileItemEventArgs e)
        {
            frmRapor R = new frmRapor();
            R.Show();
        }
    }
}