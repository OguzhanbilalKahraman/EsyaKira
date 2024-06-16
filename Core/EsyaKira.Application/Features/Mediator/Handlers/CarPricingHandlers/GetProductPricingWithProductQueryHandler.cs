using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsyaKira.Application.Features.Mediator.Queries.ProductPricingQueries;

using EsyaKira.Application.Features.Mediator.Results.ProductPricingResults;
using EsyaKira.Application.Features.Mediator.Results.LocationResults;
using EsyaKira.Application.Interfaces.ProductPricingInterfaces;

namespace EsyaKira.Application.Features.Mediator.Handlers.ProductPricingHandlers
{
    public class GetProductPricingWithProductQueryHandler : IRequestHandler<GetProductPricingWithProductQuery, List<GetProductPricingWithProductQueryResult>>
    {
        private readonly IProductPricingRepository _repository;
        public GetProductPricingWithProductQueryHandler(IProductPricingRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetProductPricingWithProductQueryResult>> Handle(GetProductPricingWithProductQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetProductPricingWithProducts();
            return values.Select(x => new GetProductPricingWithProductQueryResult
            {
                Amount = x.Amount,
                ProductPricingId = x.ProductPricingID,
                Brand = x.Product.Brand.Name,
                CoverImageUrl = x.Product.CoverImageUrl,
                Model = x.Product.Model,
                ProductId = x.ProductID
             
            }).ToList();
        }
    }
}
