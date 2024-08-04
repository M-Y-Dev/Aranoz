using Aranoz.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class Basket : BaseEntity
    {
        public int AppUserId { get; set; }
        public List<BasketItem> BasketItem { get; set; }
        public decimal TotalAmount => BasketItem?.Sum(item => item.TotalPrice) ?? 0;
    }
}
