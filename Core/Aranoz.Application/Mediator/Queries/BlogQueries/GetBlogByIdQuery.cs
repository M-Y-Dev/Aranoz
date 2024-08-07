using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.BlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdQuery : IRequest<Response<GetBlogByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }
    }
}
