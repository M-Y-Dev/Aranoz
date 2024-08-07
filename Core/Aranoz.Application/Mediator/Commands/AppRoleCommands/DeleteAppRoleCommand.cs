using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.AppRoleCommands
{
    public class DeleteAppRoleCommand : IRequest<Response<object>>
    { 
        public int Id { get; set; }

        public DeleteAppRoleCommand(int id)
        {
            Id = id;
        }
    }
}
