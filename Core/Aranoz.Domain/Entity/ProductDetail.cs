using Aranoz.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class ProductDetail : BaseEntity
    {
        
        public string ProductName { get; set; }
        public Product Product { get; set; }
        public string BrandName { get; set; }
        public Brand Brand { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Rating { get; set; }
    }
}
