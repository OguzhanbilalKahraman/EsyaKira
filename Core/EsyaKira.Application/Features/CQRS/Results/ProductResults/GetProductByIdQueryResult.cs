using EsyaKira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Features.CQRS.Results.ProductResults
{
    public class GetProductByIdQueryResult
    {
        public int ProductID { get; set; }

        public int BrandID { get; set; }
        

        public string Model { get; set; }

        public string CoverImageUrl { get; set; }

        public string BigImageUrl { get; set; }
    }
}
