using EsyaKira.Application.Features.CQRS.Commands.ProductCommands;
using EsyaKira.Application.Features.CQRS.Queries.ProductQueries;
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
    public class GetProductByIdQueryHandler
    {
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetProductByIdQueryResult
            {

                BigImageUrl = values.BigImageUrl,
                BrandID = values.BrandID,
                CoverImageUrl = values.CoverImageUrl,
                Model = values.Model,
                ProductID = values.ProductID



            };
        }
    }
}
