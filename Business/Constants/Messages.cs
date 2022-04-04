using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    //constant : sabit proje sabitleri bunun içine konur database özleinde metinler mesajlar inumlar gibi gibi
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün bulunabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir isim var. ";
        internal static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
