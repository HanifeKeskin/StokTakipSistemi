using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip1.Model;


namespace StokTakip1.Controller
{
    public static class HoldingSirketController
    {
        public static List<Holdingler> HoldingleriListele()
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Holdingler.ToList();
                return result.ToList();
            }
        }
        public static List<Sirketler> SirketleriListele(int holdingId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Sirketler.Where(x => x.HoldingId == holdingId);
                return result.ToList();
            }
        }
    }
}
