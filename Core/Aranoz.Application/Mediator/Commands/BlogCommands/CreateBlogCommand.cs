using Aranoz.Application.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Commands.BlogCommands
{
    public class CreateBlogCommand : IRequest<Response<object>>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public int BlogCategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
