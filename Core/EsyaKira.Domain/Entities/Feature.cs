using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Domain.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }

        public string Name { get; set; }

        public List<ProductFeature> ProductFeatures { get; set; }
    }
}
