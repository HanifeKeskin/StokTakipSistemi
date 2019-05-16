using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using StokTakip1.Model;

namespace StokTakip1.Controller
{
    public static class PersonellerController
    {
        public static List<Kisi> KullanicilariListele()
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Kisi;
                return result.ToList();
            }
        }
        public static KisiKullaniciViewModel KisiGetir(int kisiId)
        {
            if (kisiId == 0)
            {
                throw new TargetParameterCountException("Kullanici Getirilemedi !");
            }
            using (var context = new YaSinamaEntities())
            {
                var result = from kisi in context.Kisi
                             join kullanici in context.Kullanici on kisi.KisiId equals kullanici.KullaniciId
                             join kullaniciRol in context.Kullanici_Role on kullanici.KullaniciId equals kullaniciRol.KullaniciId
                             join rol in context.Roller on kullaniciRol.RoleId equals rol.RoleId
                             select new KisiKullaniciViewModel
                             {
                                 Kisi = kisi,
                                 Kullanici = kullanici,
                                 Rol = rol
                             };
                return result.FirstOrDefault(x => x.Kisi.KisiId == kisiId);
            }
        }

        public static List<DepartmanKisiViewModel> KullaniciZimmetleri(int kisiId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = from departman in context.Departmanlar
                             join zim in context.Zimmet on departman.DepartmanId equals zim.DepartmanId
                             join demirbasDepartman in context.Demirbas_Departman on zim.ZimmetId equals demirbasDepartman.ZimmetId
                             join db in context.Demirbas on demirbasDepartman.DemirbasId equals db.DemirbasNo
                             join k in context.Kisi on zim.KisiId equals k.KisiId
                             select new DepartmanKisiViewModel
                             {
                                 Kisi = k,
                                 Departman = departman,
                                 Zimmet = zim,
                                 Demirbas = db
                             };
                return result.Where(x => x.Kisi.KisiId == kisiId).ToList();
            }
        }

        public static List<DepartmanKisiViewModel> KullaniciSorumluDepartmanlar(int kisiId)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = from departman in context.Departmanlar
                             join zim in context.Zimmet on departman.DepartmanId equals zim.DepartmanId
                             join k in context.Kisi on zim.KisiId equals k.KisiId
                             select new DepartmanKisiViewModel
                             {
                                 Kisi = k,
                                 Departman = departman,
                                 Zimmet = zim,

                             };
                return result.Where(x => x.Kisi.KisiId == kisiId).ToList();
            }
        }

    }
}

