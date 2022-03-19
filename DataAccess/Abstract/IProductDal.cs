using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // I interface olduğunu belirtir Product entity nin yani tabloda karşılıkk geldiği yeri, dal ise 
    // Data access layer hangi katmanın kodu olduğu anlatılır.
    // Dao Data Access Object
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
