using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // classın içinde metotların dışında tanımlanan değişkenler o sınıf için
                                 // global bir değişken anlamına gelir genellikle "_" ile başlatılır.

        //class ismiyle aynı bir class tanımlanınca constructor olur bu da kod çalışnmaya başladığı anda çalışacak kodlar vardır.
        public InMemoryProductDal()
        {
            //oracle,sql,server,postgres,monodb gibi database lerden gelen verilerin simule edilemesi aşağıdaki işlem
            _products = new List<Product>()
            {
                new Product{CategoryId=1, ProductId=1, ProductName="Bardak", UnitsInStock=15, UnitPrice=15},
                new Product{CategoryId=2, ProductId=1, ProductName="Kamera", UnitsInStock=500, UnitPrice=3},
                new Product{CategoryId=3, ProductId=2, ProductName="Telefon", UnitsInStock=1500, UnitPrice=2},
                new Product{CategoryId=4, ProductId=2, ProductName="Klavye", UnitsInStock=150, UnitPrice=65},
                new Product{CategoryId=5, ProductId=2, ProductName="Fare", UnitsInStock=85, UnitPrice=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - language Integrated Query Dile Gömülü Sorgulama liste bazlı yapıları sql gibi filtreniyor
            //Lambda => buna lambda denir.

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // yukarıda ki foreach in yaptığı işi linq ile bu kodla yapılır


            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}



            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return  _products.Where(p => p.CategoryId == categoryId).ToList();  
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // yukarıda ki foreach in yaptığı işi linq ile bu kodla yapılır
            productToUpdate.ProductName= product.ProductName;

        }
    }
}
