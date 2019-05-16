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

namespace StokTakip1.Views.Demirbas
{
    public partial class frmDemirbasIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasIslemleri()
        {
            InitializeComponent();
        }

        private void btn_DemirbasEkle_ItemClick(object sender, TileItemEventArgs e)
        {
            frmDemirbasEkle DE = new frmDemirbasEkle();
            DE.Show();
            this.Hide();
        }
    }
}