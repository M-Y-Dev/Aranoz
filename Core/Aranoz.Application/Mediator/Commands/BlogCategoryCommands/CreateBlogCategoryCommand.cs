using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.BlogCategoryCommands
{
    public class CreateBlogCategoryCommand:IRequest<Response<object>>
    {
        public string CategoryName { get; set; }
    }
}
