using EsyaKira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Interfaces.ProductInterfaces
{
    public interface IProductRepository
    {
        List<Product> GetProductsListWithBrands();
        List<Product> GetLast5ProductsListWithBrands();

        int GetProductCount();

    }
}
