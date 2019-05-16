using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip1.Model
{
    public static class KategorilerViewModel
    {
        public static List<Kategori> KategorileriListele()
        {
            using (var context = new YaSinamaEntities())
            {
                return context.Kategori.ToList();
            }
        }
    }
}
