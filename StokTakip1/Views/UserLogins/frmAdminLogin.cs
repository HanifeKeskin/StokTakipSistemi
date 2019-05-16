using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Security.Authentication;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokTakip1.Controller;
using StokTakip1.Model;
using StokTakip1.Views;

namespace StokTakip1.Views.UserLogins
{
    public partial class frmAdminLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void frmAdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin lf = new frmLogin();
            lf.Show();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici user = new Kullanici();
                user.Sifre = txtSifre.Text;
                string md5 = Tools.CreateMD5(user.Sifre);
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
                {
                    throw new ValidationException("Kullanıcı Adı veya Şifre Boş Geçilemez !");
                }
                else
                {
                    user.KullaniciId = Convert.ToInt16(txtKullaniciAdi.Text);
                }
                user.Sifre = md5;
                var result = UsersController.UserAdminLogin(user);
                frmLogin._session = ERoles.Admin.ToString();
                frmLogin._userIdSession = result.KullaniciId;
                frmAdmin af = new frmAdmin();
                af.Show();
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