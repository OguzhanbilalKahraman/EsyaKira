using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Domain.Entities
{
    public class ProductDescription
    {
        public int ProductDescriptionID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public string Detail { get; set;}
    }
}
