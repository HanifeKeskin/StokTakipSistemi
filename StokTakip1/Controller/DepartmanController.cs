using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip1.Model;

namespace StokTakip1.Controller
{
    public static class DepartmanController
    {
        public static void DepartmanEkle(string departmanAdi, int sirketId)
        {
            if (string.IsNullOrEmpty(departmanAdi) || sirketId == 0)
            {
                throw new ValidationException("DepartmanAdi ve SirketId Boş Geçilemez !");
            }
            var result = TumDepartmanlariGetir().FirstOrDefault(x => x.Departman.DepartmanAdi == departmanAdi);
            if (result != null)
            {
                throw new Exception("Bu isimdeki departman mevcuttur!");
            }
            using (var context = new YaSinamaEntities())
            {
                context.sp_DepartmanEkle(departmanAdi, sirketId);
            }

        }
        public static void DepartmanGuncelle(int departmanId, string departmanAdi, int sirketId, int kisiId)
        {
            using (var context = new YaSinamaEntities())
            {
                context.sp_DepartmanGuncelle(departmanId, departmanAdi, sirketId, kisiId);
            }
        }
        public static void DepartmanSil(int departmanId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Departmanlar.FirstOrDefault(x => x.DepartmanId == departmanId);
                context.Entry(result).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static DepartmanHoldingSirketViewModel DepartmanDetayiGetir(int departmanId)
        {
            if (departmanId == 0)
            {
                throw new ValidationException("Departman Id Boş Geldi !");
            }
            var result = TumDepartmanlariGetir().FirstOrDefault(x => x.Departman.DepartmanId == departmanId);
            return result;
        }

        //Sorgu Stored Procedure Olduğu için IEnumarable<object> halinde dönmek zorunda çünkü complex type bir nesne geriye döndüğü için class hali mevcut değil.
        /*public static List<Object> DepartmanDemirbaslariList(int departmanId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.sp_Departmandaki_Demirbas02(departmanId);
                return result.ToList();
            }
        }*/
        public static List<DepartmanHoldingSirketViewModel> TumDepartmanlariGetir()
        {
            using (var context = new YaSinamaEntities())
            {
                var result = from departmanHoldingSirket in context.DepartmanHoldingSirket
                             join departman in context.Departmanlar on departmanHoldingSirket.DepartmanId equals departman.DepartmanId
                             join sirket in context.Sirketler on departmanHoldingSirket.SirketId equals sirket.SirketId
                             join holding in context.Holdingler on sirket.HoldingId equals holding.HoldingId
                             select new DepartmanHoldingSirketViewModel
                             {
                                 Sirket = sirket,
                                 Holding = holding,
                                 Departman = departman
                             };
                return result.ToList();
            }
        }

        public static void DepartmanYetkilendir(int kisiId, int DepartmanId)
        {
            using (var context = new YaSinamaEntities())
            {
                Zimmet z = new Zimmet();
                z.KisiId = kisiId;
                z.DepartmanId = DepartmanId;
                context.Zimmet.Add(z);
                context.SaveChanges();
                
            }
        }
    }
}

