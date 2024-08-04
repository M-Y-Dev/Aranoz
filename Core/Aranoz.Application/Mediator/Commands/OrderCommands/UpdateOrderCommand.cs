using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.OrderCommands
{
    public class UpdateOrderCommand:IRequest<Response<object>>
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; } // Ürünün adet fiyatı
        public DateTime OrderDate { get; set; }
    }
}
