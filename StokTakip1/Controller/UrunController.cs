using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using StokTakip1.Model;

namespace StokTakip1.Controller
{
    public static class UrunController
    {
        public static void UrunEkle(Urun urun, int stok)
        {
            if (urun == null || stok == 0)
            {
                throw new ValidationException("Hata");
            }
            using (var context = new YaSinamaEntities())
            {
                context.sp_UrunEkle(urun.KategoriId, urun.UrunAdi, urun.UrunBirimFiyati, stok, urun.SatinAlinmaTarihi);
            }
        }
        public static void UrunDuzenle(Urun urun, int stok)
        {
            using (var context = new YaSinamaEntities())
            {
                context.sp_UrunGuncelle(urun.UrunId, urun.KategoriId, urun.UrunAdi, urun.UrunBirimFiyati, stok, urun.SatinAlinmaTarihi);
            }
        }
        public static void UrunSil(int urunId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Urun.FirstOrDefault(x => x.UrunId == urunId);
                context.Entry(result).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static StokUrunViewModel UrunGetir(int urunId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = from urunStok in context.Urun_Stok
                             join urun in context.Urun
                                 on urunStok.UrunId equals urun.UrunId
                             select new StokUrunViewModel
                             {
                                 Urun = urun,
                                 UrunStok = urunStok
                             };

                return result.FirstOrDefault(x => x.Urun.UrunId == urunId);
            }
        }
        public static List<StokUrunViewModel> SilinenleriGetir()
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
                return result.Where(x => x.Urun.Silindi == Convert.ToBoolean(EDeleted.silindi)).ToList();
            }
        }


    }
}
