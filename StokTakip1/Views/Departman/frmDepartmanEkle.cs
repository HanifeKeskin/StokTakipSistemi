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
using StokTakip1.Controller;
using StokTakip1.Model;

namespace StokTakip1.Views.Departman
{
    public partial class frmDepartmanEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartmanEkle()
        {
            InitializeComponent();
        }

        private void btn_DepartmanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_DepartmanAdi.Text))
                {
                    throw new ValidationException("Oda Adını Boş Geçemezsiniz !");
                }
                DepartmanController.DepartmanEkle(txt_DepartmanAdi.Text, Convert.ToInt32(cmb_Sirket.SelectedValue));
                MessageBox.Show("Departman Başarıyla Eklendi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Meydana Geldi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_Holding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Holding.SelectedIndex == -1) return;
            //int fakulte = int.Parse(cmb_Holding.SelectedValue.ToString());
            int a = (cmb_Holding.SelectedIndex) + 1;
            Tools.ComboBoxBolumGetir(cmb_Sirket, a);
        }

        private void frmDepartman_Load(object sender, EventArgs e)
        {
            Tools.ComboBoxHoldingGetir(cmb_Holding);
        }

        private void txt_DepartmanAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void txt_DepartmanAdi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceHarf(sender, e);

        }
    }
}