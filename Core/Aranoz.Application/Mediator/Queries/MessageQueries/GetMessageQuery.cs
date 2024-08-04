using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.MessageResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.MessageQueries
{
    public class GetMessageQuery : IRequest<Response<List<GetMessageQueryResult>>>
    {
    }
}
