using EsyaKira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Interfaces.ProductPricingInterfaces
{
    public interface IProductPricingRepository
    {

        List<ProductPricing> GetProductPricingWithProducts();
    }
}
