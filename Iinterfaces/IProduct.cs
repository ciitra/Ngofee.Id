using Ngofee.Id.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngofee.Id.Iinterfaces
{
    public interface IProduct
    {
        void CreateProduct(Product product);

        List<Product> GetByUserId(int userId);
        List<Product> GetAllProduct();
        void DeleteProduct(int productId);
    }
}
