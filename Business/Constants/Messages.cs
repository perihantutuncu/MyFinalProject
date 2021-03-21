using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string UnitPriceInvalid = "Birim fiyat geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir!";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductAlreadyExists = "Bu ürün isminde başka bir ürün vardır";
        public static string CategoryLimitExceded = "Kategoi limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string UserRegistered = "Kayıt oldu";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = " Parola hatası";
        internal static string SuccessfulLogin = "Başarılı giriş";
        internal static string UserAlreadyExists = "Kullanıcı mevcut";
        internal static string AccessTokenCreated = "Token oluşturuldu";
    }
}
