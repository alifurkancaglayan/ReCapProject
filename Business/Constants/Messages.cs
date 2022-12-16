using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string ColorAdded = "Renk eklendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string RentalAdded = "Kiralama eklendi.";

        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string ColorNameInvalid = "Renk ismi geçersiz.";
        public static string BrandNameInvalid = "Marka ismi geçersiz.";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz.";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz.";

        public static string MaintenanceTime = "Sistem Bakımda.";

        public static string CarsListed = "Arabalar Listelendi.";
        public static string ColorsListed = "Renkler Listelendi.";
        public static string BrandsListed = "Markalar Listelendi.";
        public static string UsersListed = "Kullanıcılar Listelendi.";
        public static string CustomersListed = "Müşteriler Listelendi.";
        public static string RentalsListed = "Kiralamalar Listelendi.";

        public static string CarDeleted = "Araba Silindi.";
        public static string ColorDeleted = "Renk Silindi.";
        public static string BrandDeleted = "Marka Silindi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string RentalDeleted = "Kiralama Silindi.";

        public static string CarUpdated = "Araba Güncellendi.";
        public static string ColorUpdated = "Renk Güncellendi.";
        public static string BrandUpdated = "Marka Güncellendi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";
        public static string RentalUpdated = "Kiralama Güncellendi.";

        public static string ImageLimitExceeded = "Bir arabanın en fazla 5 resmi olabilir.";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
