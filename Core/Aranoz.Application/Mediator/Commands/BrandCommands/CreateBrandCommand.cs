using Aranoz.Application.Base;
using Aranoz.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.BrandCommands
{
    public class CreateBrandCommand : IRequest<Response<object>>
    {
        public string BrandName { get; set; }
        
    }
}
