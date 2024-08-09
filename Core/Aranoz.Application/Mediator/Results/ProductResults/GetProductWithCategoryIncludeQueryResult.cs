using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Results.ProductResults
{
    public class GetProductWithCategoryIncludeQueryResult
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public int ProductStock { get; set; }
        public decimal Price { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName{ get; set; }
    }
}
