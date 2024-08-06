using Aranoz.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Results.BrandResults
{
    public class GetBrandQueryResult
    {
        public string BrandName { get; set; }
        public List<Product> Products { get; set; }
    }
}
