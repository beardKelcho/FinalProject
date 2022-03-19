// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductTest();

//CategoryTest();






static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfPorductDal());

    foreach (var product in productManager.GetProductDetail())
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}