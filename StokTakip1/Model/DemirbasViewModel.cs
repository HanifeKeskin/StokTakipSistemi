using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip1.Model
{
    public class DemirbasViewModel
    {
        public DemirbasViewModel()
        {
            Holding = new Holdingler();
            Sirket = new Sirketler();
            Kategori = new Kategori();
            Demirbas = new Demirbas();
            Urun = new Urun();
        }
        public Holdingler Holding { get; set; }
        public Sirketler Sirket { get; set; }
        public Urun Urun { get; set; }
        public Demirbas Demirbas { get; set; }
        public Kategori Kategori { get; set; }
    }
}
