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
    public class UpdateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand command)
        {
            var values = await _repository.GetByIdAsync(command.ProductID);
            values.BigImageUrl = command.BigImageUrl;
            values.CoverImageUrl = command.CoverImageUrl;
            values.Model = command.Model;
           

            await _repository.UpdateAsync(values);

        }
    }
}
