using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        public string Model { get; set; }

        public string CoverImageUrl { get; set; }

        public string BigImageUrl { get; set;}

        public List<ProductFeature> ProductFeatures { get; set;}

        public List<ProductDescription> ProductDescriptions { get; set; }

        public List<ProductPricing> ProductPricings { get; set; }





    }
}
