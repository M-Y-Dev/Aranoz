using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.BasketCommands
{
    public class DeleteBasketCommand : IRequest<Response<object>>
    {
        public int Id { get; set; }

        public DeleteBasketCommand(int id)
        {
            Id = id;
        }
    }
}
