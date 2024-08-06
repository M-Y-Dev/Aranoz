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
    public class UpdateBrandCommand : IRequest<Response<object>>
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
       
    }
}
