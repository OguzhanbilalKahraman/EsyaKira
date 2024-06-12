using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Application.Features.Mediator.Results.ProductPricingResults
{
    public class GetProductPricingWithProductQueryResult
    {
        public int ProductId { get; set; }
        public int ProductPricingId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Amount { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
