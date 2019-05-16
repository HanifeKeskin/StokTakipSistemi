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

namespace StokTakip1.Views.Stok
{
    public partial class frmStokIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public frmStokIslemleri()
        {
            InitializeComponent();
        }

        private void btn_StogaUrunEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            frmStokaUrunEkle SUE = new frmStokaUrunEkle();
            SUE.Show();
            this.Hide();
        }
    }
}