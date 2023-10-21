using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Models.Interfaces
{
    internal interface IProductModeRepository
    {
        void Add(ProductModel productModel);
        void Edit(ProductModel productModel);
        void Delete(int id);

        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);
    }
}
