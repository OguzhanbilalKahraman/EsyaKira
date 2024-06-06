using EsyaKira.Application.Features.CQRS.Results.ProductResults;
using EsyaKira.Application.Interfaces.ProductInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductWithBrandQueryHandler
    {
        private readonly IProductRepository _repository;

        public GetProductWithBrandQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<GetProductWithBrandQueryResult> Handle()
        {
            var values=_repository.GetProductsListWithBrands();
            return values.Select(x=> new GetProductWithBrandQueryResult
            {
                BrandName = x.Brand.Name,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                ProductID = x.ProductID,
                CoverImageUrl = x.CoverImageUrl,
                Model = x.Model

            }).ToList();
        }
    }
}
