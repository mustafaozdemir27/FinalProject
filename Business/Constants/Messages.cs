using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // Cagirildigi yerde new'leme yapmamak icin ve const(sabit) oldugu icin static tanimladim
    public static class Messages
    {
        // publicler degisken dahi olsa PascalCase yazilir
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım dolayısıyla ürünler geçiçi olarak listelenemiyor";
        public static string ProductsListed="Ürünler listelendi";
    }
}
