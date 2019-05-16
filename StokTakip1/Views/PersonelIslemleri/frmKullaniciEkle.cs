using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip1.Model;
using StokTakip1.Controller;

namespace StokTakip1.Views.PersonelIslemleri
{
    public partial class frmKullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btn_KullaniciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciId.Text) || string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text) || string.IsNullOrEmpty(txtKullaniciRolu.Text))
            {
                throw new ValidationException("Ürün Bilgileri Boş Geçilemez !");
            }
            Kullanici kullanici = new Kullanici();
            Roller rol = new Roller();
            kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            kullanici.KullaniciId = Convert.ToInt32(txtKullaniciId.Text);
            rol.RolAdi = txtKullaniciRolu.Text;
            kullanici.Sifre = txtSifre.Text;
            kullanici.Silindi = false;

            MessageBox.Show("Kullanici Eklendi!", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmKullaniciEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPersonelIslemleri PI = new frmPersonelIslemleri();
            PI.Show();
        }

        private void txtKullaniciId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceHarf(sender, e);

        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }
    }
}