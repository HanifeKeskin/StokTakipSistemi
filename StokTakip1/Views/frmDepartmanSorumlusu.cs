using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakip1.Views.Personel;
using DevExpress.XtraEditors;

namespace StokTakip1.Views
{
    public partial class frmDepartmanSorumlusu : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartmanSorumlusu()
        {
            InitializeComponent();
        }

        private void btn_Personeller_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDepartmanPersonelList PL = new frmDepartmanPersonelList();
            PL.Show();
            this.Hide();

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            frmLogin lf = new frmLogin();
            lf.Show();
            this.Hide();
        }

        private void frmDepartmanSorumlusu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin lf = new frmLogin();
            lf.Show();
        }
    }
}