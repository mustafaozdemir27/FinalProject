// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

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
    foreach (var product in productManager.GetAll())
    {
        Console.WriteLine($"ProductName ={product.ProductName}");
    }
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("Kategoriye gore productlar");
    Console.WriteLine();
    foreach (var product in productManager.GetAllByCategoryId(1))
    {
        Console.WriteLine($"ProductName ={product.ProductName}");
    }

    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("UnitPrice'a productlar");
    Console.WriteLine();
    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine($"ProductName ={product.ProductName} / CategoryName ={product.CategoryName}");
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