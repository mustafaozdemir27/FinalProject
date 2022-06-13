// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

// SOLID 
// Open Closed Principle
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
foreach (var product in productManager.GetByUnitPrice(50,100))
{
    Console.WriteLine($"ProductName ={product.ProductName}");
}