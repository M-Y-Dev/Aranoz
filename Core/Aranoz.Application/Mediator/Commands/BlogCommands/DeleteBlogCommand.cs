using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.BlogCommands
{
    public class DeleteBlogCommand : IRequest<Response<object>>
    {
        public int Id { get; set; }

        public DeleteBlogCommand(int id)
        {
            Id = id;
        }
    }
}
