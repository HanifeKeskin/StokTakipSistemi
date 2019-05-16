using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using StokTakip1.Model;

namespace StokTakip1.Controller
{
    public static class UsersController
    {
        public static Kullanici UserAdminLogin(Kullanici modelUser)
        {
            if (string.IsNullOrEmpty(Convert.ToString(modelUser.KullaniciId)) && string.IsNullOrEmpty(modelUser.Sifre))
            {
                throw new AuthenticationException("Kullanici Verileri Boş Geçilemez !");
            }
            using (var context = new YaSinamaEntities())
            {
               // context.Database.Connection.Open();
                var result = context.Kullanici.FirstOrDefault(x => x.KullaniciId == modelUser.KullaniciId && x.Sifre == modelUser.Sifre);

                if (result == null || result.Silindi == Convert.ToBoolean(EDeleted.silindi))
                {
                    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                }
                var roleResult = context.Kullanici_Role.FirstOrDefault(x => x.KullaniciId == result.KullaniciId);
                if (roleResult.RoleId != (int)ERoles.Admin)
                {
                    throw new AuthenticationException("Kullanıcı Bilgileriniz Bu Sayfayı Açmak İçin Yeterli Değil ! \n Lütfen Standart Kullanıcı Biriminden Giriş Yapınız !");
                }
                UserLoginDate(result);
                return result;
            }
        }
        public static Kullanici UserStandartLogin(Kullanici modelUser)
        {
            if (modelUser == null)
            {
                throw new ValidationException("Lütfen Kullanıcı Bilgilerinizi Lütfen Boş Geçmeyiniz !");
            }
            using (var context = new YaSinamaEntities())
            {
                var result = context.Kullanici.FirstOrDefault(x => x.KullaniciAdi == modelUser.KullaniciAdi && x.Sifre == modelUser.Sifre);
                if (result == null || result.Silindi == Convert.ToBoolean(EDeleted.silindi))
                {
                    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                }
                var roleResult = context.Kullanici_Role.FirstOrDefault(x => x.KullaniciId == result.KullaniciId);
                if (roleResult.RoleId != (int)ERoles.SatisSorumlusu)
                {
                    throw new AuthenticationException("Yönetici Bilgileri İle Giriş Yapıyorsunuz !\nLütfen Yönetici Kullanıcı Biriminden Giriş Yapınız !");
                }
                UserLoginDate(result);
                return result;
            }
        }
        private static void UserLoginDate(Kullanici modelUser)
        {
            using (var context = new YaSinamaEntities())
            {
                var result = context.Kullanici.FirstOrDefault(x => x.KullaniciId == modelUser.KullaniciId);
                if (result != null)
                {
                    result.SonGirisTarihi = DateTime.Now;
                    context.Entry(result).State = System.Data.Entity.EntityState.Modified; // EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        /*public static Kullanici KullaniciEkle()
        {

        }*/

    }
}

