using Aranoz.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
