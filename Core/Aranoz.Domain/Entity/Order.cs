using Aranoz.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Domain.Entity
{
    public class Order:BaseEntity
    {
        
        public int AppUserId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; } // Ürünün adet fiyatı
        public DateTime OrderDate { get; set; }

    }
}
