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

namespace StokTakip1.Views.ZimmetIslemleri
{
    public partial class frmZimmet : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmZimmet()
        {
            InitializeComponent();
        }

        private void txtPersonelId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void frmZimmet_Load(object sender, EventArgs e)
        {
            Tools.ComboBoxKategorileriGetir(cmb_UrunKategori);
        }

        private void btn_Zimmetle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = Convert.ToDateTime(calendarControl1.SelectionStart.ToShortDateString());
                if (string.IsNullOrEmpty(txt_UrunAdi.Text) || string.IsNullOrEmpty(txtPersonelId.Text) || string.IsNullOrEmpty(cmb_UrunKategori.Text))
                {
                    throw new ValidationException("Bilgiler Boş Girilemez !");
                }
                if (int.Parse(txtPersonelId.Text) <= 0)
                {
                    throw new ValidationException("Personel ID Sıfır veya Daha Düşük Değerler Olamaz !");
                }
                if (selectedDate > DateTime.Now)
                {
                    throw new ValidationException("Satın alma tarihi bugünden daha sonraki bir tarih olamaz!");
                }
                Zimmet zimmet = new Model.Zimmet();
                zimmet.ZimmetId = 2;
                zimmet.KisiId = Convert.ToInt16(txtPersonelId.Text);
                zimmet.DepartmanId = Convert.ToInt16(txtDepartmanId.Text);
                MessageBox.Show("Ürün Başarıyla Zimmetlendi!", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtDepartmanId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txt_UrunAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceHarf(sender, e);

        }
    }
}