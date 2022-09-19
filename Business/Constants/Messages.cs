
namespace Business.Constants
{
    // Cagirildigi yerde new'leme yapmamak icin ve const(sabit) oldugu icin static tanimladim
    public static class Messages
    {
        // publicler degisken dahi olsa PascalCase yazilir
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Bakım dolayısıyla ürünler geçiçi olarak listelenemiyor";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";



    }
}
     