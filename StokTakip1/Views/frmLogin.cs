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
using StokTakip1.Controller;
using StokTakip1.Model;
using StokTakip1.Views;
using StokTakip1.Views.UserLogins;

namespace StokTakip1.Views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string _session { get; set; }
        public static int _userIdSession { get; set; }
        private void btnAdminItemClick(object sender, TileItemEventArgs e)
        {
            frmAdminLogin ALF = new frmAdminLogin();
            ALF.Show();
            this.Hide();
        }

        private void btnSatisSorumlusu_ItemClick(object sender, TileItemEventArgs e)
        {
            frmSatisSorumlusuLogin slForm = new frmSatisSorumlusuLogin();
            slForm.Show();
            this.Hide();
        }

        private void btnDepartmanSorumlusu_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepartmanSorumlusuLogin slForm = new frmDepartmanSorumlusuLogin();
            slForm.Show();
            this.Hide();
        }

    }
}