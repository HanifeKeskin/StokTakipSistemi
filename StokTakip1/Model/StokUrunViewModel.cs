using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip1.Model
{
    public class StokUrunViewModel
    {
        public Urun_Stok UrunStok { get; set; }
        public decimal ToplamFiyat => UrunStok.Stok * Urun.UrunBirimFiyati;
        public Urun Urun { get; set; }

    }
}
