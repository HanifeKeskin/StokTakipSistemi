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
using StokTakip1.Views.Departman;
using StokTakip1.Views.Personel;
using StokTakip1.Views.Stok;
using StokTakip1.Views.Demirbas;

namespace StokTakip1.Views
{
    public partial class frmSatisSorumlusu : DevExpress.XtraEditors.XtraForm
    {
        public frmSatisSorumlusu()
        {
            InitializeComponent();
        }

        private void btn_DepartmanEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepartmanEkle D = new frmDepartmanEkle();
            D.Show();
            this.Hide();
        }

        private void btn_PersonelleriListele_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepartmanPersonelList PL = new frmDepartmanPersonelList();
            PL.Show();
            this.Hide();
        }

        private void btn_StokIslemleri_ItemClick(object sender, TileItemEventArgs e)
        {
            frmStokIslemleri SI = new frmStokIslemleri();
            SI.Show();
            this.Hide();
        }

        private void bnt_DemirbasIslemleri_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDemirbasIslemleri DI = new frmDemirbasIslemleri();
            DI.Show();
            this.Hide();
        }

        private void btn_Cikis_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void frmSatisSorumlusu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}