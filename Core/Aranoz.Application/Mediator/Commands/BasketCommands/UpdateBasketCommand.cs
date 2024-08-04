using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.BasketCommands
{
    public class UpdateBasketCommand : IRequest<Response<object>>
    {
        public int Id { get; set; }

        public int AppUserId { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
