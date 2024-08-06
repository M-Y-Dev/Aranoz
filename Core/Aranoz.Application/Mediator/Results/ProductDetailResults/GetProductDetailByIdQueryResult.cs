using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Results.ProductDetailResults
{
    public class GetProductDetailByIdQueryResult
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Rating { get; set; }
    }
}
