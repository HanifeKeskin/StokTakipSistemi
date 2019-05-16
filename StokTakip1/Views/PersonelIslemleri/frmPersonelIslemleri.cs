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
using StokTakip1.Views.Personel;

namespace StokTakip1.Views.PersonelIslemleri
{
    public partial class frmPersonelIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public frmPersonelIslemleri()
        {
            InitializeComponent();
        }

        private void btnPersonelleriListele_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepartmanPersonelList DPL = new frmDepartmanPersonelList();
            DPL.Show();
            this.Hide();
        }

        private void btn_KullaniciEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            frmKullaniciEkle KE = new frmKullaniciEkle();
            KE.Show();
            this.Hide();
        }

        private void frmPersonelIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmAdmin A = new frmAdmin();
            A.Show();
        }
    }
}