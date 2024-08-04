using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.OrderCommands
{
    public class CreateOrderCommand:IRequest<Response<object>>
    {
        public int AppUserId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
