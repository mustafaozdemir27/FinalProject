// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

// SOLID 
// Data Transformation Object
// Open Closed Principle
ProductTest();
// IoC
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    Console.WriteLine("Tum Productlar");
    Console.WriteLine();
    foreach (var product in productManager.GetAll().Data)
    {
        Console.WriteLine($"ProductName ={product.ProductName}");
    }
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Kategoriye gore productlar");
    Console.WriteLine();
    foreach (var product in productManager.GetAllByCategoryId(1).Data)
    {
        Console.WriteLine($"ProductName ={product.ProductName}");
    }

    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("UnitPrice'a productlar");
    Console.WriteLine();
    foreach (var product in productManager.GetProductDetails().Data)
    {
        Console.WriteLine($"ProductName ={product.ProductName} / CategoryName ={product.CategoryName}");
    }

    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Productdetails Methoduna Gore Productlar");
    Console.WriteLine();

    var result = productManager.GetProductDetails();
    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine($"{product.ProductName} / {product.CategoryName}");
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    Console.WriteLine("Tum Kategoriler");
    Console.WriteLine();
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine($"CategoryName ={category.CategoryName}");
    }
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("id'ye gore kategoriler");
    Console.WriteLine();
    Console.WriteLine($"CategoryName ={categoryManager.GetById(2).CategoryName}");
}