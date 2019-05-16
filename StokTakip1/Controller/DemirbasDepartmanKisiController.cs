using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip1.Model;

namespace StokTakip1.Controller
{
    public static class DemirbasDepartmanKisiController
    {
        public static void DepartmanDemirbasEkle(int demirbasId, int departmanId, int adet)
        {
            using (var context = new YaSinamaEntities())
            {
                context.sp_DepartmanDemirbasEkle(demirbasId, departmanId, adet);
            }
        }

        public static void DepartmanaDemirbasEkle(int demirbasId, int departmanId, int adet)
        {
            using (var context = new YaSinamaEntities())
            {
                context.sp_DepartmanDemirbasEkle(demirbasId, departmanId, adet);
            }
        }
        public static void DepartmanDemirbasSil(int demirbasDepartmanId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Demirbas_Departman.FirstOrDefault(x => x.DemirbasDepartmanId == demirbasDepartmanId);
                context.Entry(result).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public static List<DepartmanKisiViewModel> DepartmanSorumlulariListele()
        {
            using (var context = new YaSinamaEntities())
            {
                var result = from k in context.Kisi
                             join z in context.Zimmet on k.KisiId equals z.KisiId
                             join d in context.Departmanlar on z.DepartmanId equals d.DepartmanId
                             select new DepartmanKisiViewModel
                             {
                                 Kisi = k,
                                 Departman = d,
                                 Zimmet = z
                             };
                return result.ToList();
            }
        }
    }
}

