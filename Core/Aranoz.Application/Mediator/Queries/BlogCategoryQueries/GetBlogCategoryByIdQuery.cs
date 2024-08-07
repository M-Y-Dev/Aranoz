using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.BlogCategoryResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.BlogCategoryQueries
{
    public class GetBlogCategoryByIdQuery : IRequest<Response<GetBlogCategoryByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetBlogCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
