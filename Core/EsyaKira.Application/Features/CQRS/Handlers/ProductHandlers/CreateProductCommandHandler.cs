using EsyaKira.Application.Features.CQRS.Commands.ProductCommands;
using EsyaKira.Application.Interfaces;
using EsyaKira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand command)
        {
            await _repository.CreateAsync(new Product
            {
                BigImageUrl = command.BigImageUrl,
                BrandID = command.BrandID,
                CoverImageUrl = command.CoverImageUrl,
                Model = command.Model


            });
        }
    }
}
