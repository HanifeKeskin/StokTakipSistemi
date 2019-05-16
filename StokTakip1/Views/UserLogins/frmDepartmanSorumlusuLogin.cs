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

namespace StokTakip1.Views.UserLogins
{
    public partial class frmDepartmanSorumlusuLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartmanSorumlusuLogin()
        {
            InitializeComponent();
        }

        private void frmDepartmanSorumlusuLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin lf = new frmLogin();
            lf.Show();
        }

        private void btnDepartmanSorumlusuGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici user = new Kullanici();
               
                user.Sifre = txtSifre.Text;
                string md5 = Tools.CreateMD5(user.Sifre);
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(md5))
                {
                    throw new ValidationException("Kullanıcı Adı ve Şifre Boş Geçilemez !");
                }
                else
                {
                    user.KullaniciId = Convert.ToInt16(txtKullaniciAdi.Text);
                }
                user.Sifre = md5;
                var result = UsersController.UserAdminLogin(user);
                frmLogin._session = ERoles.Admin.ToString();
                frmLogin._userIdSession = result.KullaniciId;
                frmDepartmanSorumlusu ds = new frmDepartmanSorumlusu();
                ds.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }
    }
}