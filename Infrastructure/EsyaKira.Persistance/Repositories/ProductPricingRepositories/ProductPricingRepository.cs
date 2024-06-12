using EsyaKira.Application.Interfaces.ProductInterfaces;
using EsyaKira.Application.Interfaces.ProductPricingInterfaces;
using EsyaKira.Domain.Entities;
using EsyaKira.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Persistance.Repositories.ProductPricingRepositories
{
    public class ProductPricingRepository : IProductPricingRepository
    {
        private readonly EsyaKiraContext _context;

        public ProductPricingRepository(EsyaKiraContext context)
        {
            _context = context;
        }

        public List<ProductPricing> GetProductPricingWithProducts()
        {
            var values = _context.ProductPricings.Include(x => x.Product).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z=> z.PricingID == 2).ToList();

            return values;
        }
    }
}
