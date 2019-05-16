using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using StokTakip1.Model;

namespace StokTakip1.Controller
{
    public static class StokController
    {
        public static List<StokUrunViewModel> StoklariGetir()
        {
            using (var context = new YaSinamaEntities())
            {
                var result = from urun in context.Urun
                             join stok in context.Urun_Stok
                                 on urun.UrunId equals stok.UrunId
                             select new StokUrunViewModel
                             {
                                 UrunStok = stok,
                                 Urun = urun
                             };
                bool silinmedi = Convert.ToBoolean(EDeleted.silinmedi);
                return result.Where(x => x.UrunStok.Stok > 0 && x.Urun.Silindi == silinmedi).ToList();
            }
        }
        public static List<StokUrunViewModel> StoktaBitenleriGetir()
        {
            using (var context = new YaSinamaEntities())
            {
                var result = from urun in context.Urun
                             join stok in context.Urun_Stok
                                 on urun.UrunId equals stok.UrunId
                             select new StokUrunViewModel
                             {
                                 UrunStok = stok,
                                 Urun = urun
                             };
                bool silinmedi = Convert.ToBoolean(EDeleted.silinmedi);
                return result.Where(x => x.UrunStok.Stok == 0 && x.Urun.Silindi == silinmedi).ToList();
            }
        }



    }
}
