using Aranoz.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public int ProductStock { get; set; }
        public decimal Price { get; set; }
       
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
    }
}
