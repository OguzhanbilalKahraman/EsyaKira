using EsyaKira.Application.Features.CQRS.Results.ProductResults;
using EsyaKira.Application.Interfaces;
using EsyaKira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly IRepository<Product> _repository;

        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle()
        {
            var values=await _repository.GetAllAsync();
            return values.Select(x=>new GetProductQueryResult
            {
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CoverImageUrl = x.CoverImageUrl,
                ProductID = x.ProductID
                

            }).ToList();
        }
    }
}
