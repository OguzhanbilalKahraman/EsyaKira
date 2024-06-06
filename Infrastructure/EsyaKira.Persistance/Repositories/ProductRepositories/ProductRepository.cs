using EsyaKira.Application.Interfaces.ProductInterfaces;
using EsyaKira.Domain.Entities;
using EsyaKira.Persistance.Context;
using Microsoft.EntityFrameworkCore;


namespace EsyaKira.Persistance.Repositories.ProductRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EsyaKiraContext _context;
        public ProductRepository(EsyaKiraContext context) 
        {
            _context = context;
        }

        public List<Product> GetProductsListWithBrands()
        {
            var values = _context.Products.Include(x=>x.Brand).ToList();
            return values;
        }

        public List<Product> GetLast5ProductsListWithBrands()
        {
            var values = _context.Products.Include(x => x.Brand).OrderByDescending(x => x.ProductID).Take(5).ToList();
            return values;
        }

        public int GetProductCount()
        {
            var value = _context.Products.Count();
            return value;
        }

       
    }
}
