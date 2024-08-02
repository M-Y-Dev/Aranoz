using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.CommentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.CommentQueries
{
    public class GetCommentQuery : IRequest<Response<List<GetCommentQueryResult>>>
    {
    }
}
