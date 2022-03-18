// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


ProductManager productManager = new ProductManager(new EfPorductDal());

foreach (var product in productManager.GetByeUnitPrice(40,100))
{
    Console.WriteLine(product.ProductName);
}
