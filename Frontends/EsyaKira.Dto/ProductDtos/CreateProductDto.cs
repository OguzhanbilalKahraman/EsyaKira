using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsyaKira.Dto.ProductDtos
{
    public class CreateProductDto
    {
  

        public int BrandID { get; set; }

        public string Model { get; set; }

        public string CoverImageUrl { get; set; }

        public string BigImageUrl { get; set; }
    }
}
