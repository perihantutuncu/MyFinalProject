using System;
using System.Collections.Generic;
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
    }
}
