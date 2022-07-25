﻿namespace Business.Constants
{
    // Cagirildigi yerde new'leme yapmamak icin ve const(sabit) oldugu icin static tanimladim
    public static class Messages
    {
        // publicler degisken dahi olsa PascalCase yazilir
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım dolayısıyla ürünler geçiçi olarak listelenemiyor";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Aynı isimde ürün eklenemez";
        public static string CategoryLimitExceded="Kategori sayısı sınırı geçtiği için ürün eklenemiyor";
    }
}
