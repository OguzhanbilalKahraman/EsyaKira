using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Domain.Entities
{
    public class Brand
    {
        public int BrandID { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }


    }
}
