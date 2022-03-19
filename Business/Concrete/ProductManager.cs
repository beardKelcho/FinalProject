using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş Kodları
            //yetkisi var mı burada kuralları veriyoruz
            return _productDal.GetAll();
        }

        public List<Product> GetAllByeCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetByeUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            return _productDal.GetProductDetails();
        }
    }
}
