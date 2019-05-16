using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip1.Model;

namespace StokTakip1.Controller
{
    public static class DemirbaslarController
    {
        public static void DemirbasEkle(DemirbasViewModel demirbas)
        {
            using (var context = new YaSinamaEntities())
            {
                context.sp_DemirbasEkle(demirbas.Holding.HoldingId, demirbas.Sirket.SirketId, demirbas.Kategori.KategoriId, demirbas.Urun.UrunId, demirbas.Demirbas.DemirbasAdedi, demirbas.Demirbas.DemirbasAciklama);
                context.SaveChanges();
            }
        }
        public static Demirbas DemirbasGetir(int demirbasNo)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Demirbas.FirstOrDefault(x => x.DemirbasNo == demirbasNo);
                return result;
                
            }
        }
        public static void DemirbasSil(int demirbasNo)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Demirbas.FirstOrDefault(x => x.DemirbasNo == demirbasNo);
                context.Entry(result).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static void DemirbasGuncelle(int demirbasNo, int holdingId, int sirketId, int kategoriId, int demirbasAdedi, string demirbasAciklama)
        {
            using (var context = new YaSinamaEntities())
            {
                context.sp_DemirbasDuzenle(demirbasNo, holdingId, sirketId, kategoriId, demirbasAdedi, demirbasAciklama);
            }
        }
        public static List<Demirbas> DemirbaslariListele()
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Demirbas.ToList();
                return result;
            }
        }


    }
}

