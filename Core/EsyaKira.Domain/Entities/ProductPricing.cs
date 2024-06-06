using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Domain.Entities
{
    public class ProductPricing
    {
        public int ProductPricingID { get; set; }

        public int ProductID { get; set; }

        public Product Product { get; set; }

        public int PricingID { get; set; }

        public Pricing Pricing { get; set; }

        public decimal Amount { get; set; }
    }
}
