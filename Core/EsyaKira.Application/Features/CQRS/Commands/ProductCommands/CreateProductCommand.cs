using EsyaKira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Features.CQRS.Commands.ProductCommands
{
    public class CreateProductCommand
    {

        public int BrandID { get; set; }
        

        public string Model { get; set; }

        public string CoverImageUrl { get; set; }

        public string BigImageUrl { get; set; }
    }
}
