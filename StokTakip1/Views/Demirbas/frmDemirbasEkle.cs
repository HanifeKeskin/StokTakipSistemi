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

namespace StokTakip1.Views.Demirbas
{
    public partial class frmDemirbasEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmDemirbasEkle()
        {
            InitializeComponent();
        }

        //private bool drm = false;
        private int _productBuyId;
        private string _productName;
        private int _selectedQuantity;

        private void btn_DemirbasEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(cmb_Faculties.SelectedValue.ToString()))
                {
                    throw new Exception("Lütfen Holding ve Departman Bilgilerini Kontrol Ediniz !");

                }
                if (string.IsNullOrEmpty(_productName) || _productBuyId == 0)
                {
                    throw new Exception("Lütfen Demirbaş Olacak Ürünü Seçiniz !");
                }
                if (string.IsNullOrEmpty(txt_Adet.Text) || short.Parse(txt_Adet.Text) == 0 || short.Parse(txt_Adet.Text) < 0)
                {
                    throw new Exception("Lütfen Adet Bilgisini Kontrol Ediniz !");
                }
                if (short.Parse(txt_Adet.Text) > _selectedQuantity)
                {
                    throw new Exception("Stok Miktarındakinden Fazla Ürün Demirbaşa Eklenemez ! !");
                }


                DemirbasViewModel model = new DemirbasViewModel
                {
                    Holding = { HoldingId = Convert.ToInt32(cmb_Faculties.SelectedValue) },
                    Sirket = { SirketId = Convert.ToInt32(cmb_Departments.SelectedValue) },
                    Kategori = { KategoriId = Convert.ToInt32(cmb_Categories.SelectedValue) },
                    Demirbas =
                    {
                        DemirbasAciklama = txt_Aciklama.Text,
                        DemirbasAdedi = Convert.ToInt32(txt_Adet.Text)
                    },
                    Urun = { UrunId = _productBuyId }
                };
                DemirbaslarController.DemirbasEkle(model);
                MessageBox.Show("Demirbaş Başarıyla Eklendi !", "Demirbaş Eklendi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStocks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmDemirbasEkle_Load(object sender, EventArgs e)
        {
            GetStocks();
            Tools.ComboBoxHoldingGetir(cmb_Faculties);
            Tools.ComboBoxKategorileriGetir(cmb_Categories);
        }
        private void GetStocks()
        {
            Tools.StoklariGrideDoldur(grid_Urunler, gridView_Urun);
        }

        private void cmb_Faculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Faculties.SelectedIndex == -1) return;
            int holding = (cmb_Faculties.SelectedIndex)+1;
            Tools.ComboBoxBolumGetir(cmb_Departments, holding);
        }

        private void gridView_Urun_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _productName = gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "UrunAdi").ToString();
                _productBuyId = int.Parse(gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "UrunId").ToString());
                _selectedQuantity = int.Parse(gridView_Urun.GetRowCellValue(gridView_Urun.FocusedRowHandle, "Adet").ToString());
                if (_selectedQuantity == 0)
                {
                    btn_DemirbasEkle.Enabled = false;
                    throw new Exception("Ürün Stoklarda Bulunmadığı Üzerinde İçin İşlem Yapılamaz !");
                }
                else
                {
                    btn_DemirbasEkle.Enabled = true;
                }
                lbl_UrunAdi.Text = _productName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            Tools.SadeceSayi(sender, e);
        }

        private void cmb_Faculties_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void frmDemirbasEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDemirbasIslemleri DI = new frmDemirbasIslemleri();
            DI.Show();
        }
    }
}