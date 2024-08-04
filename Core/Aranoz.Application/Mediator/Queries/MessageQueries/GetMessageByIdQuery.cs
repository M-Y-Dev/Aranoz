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
    public class GetMessageByIdQuery : IRequest<Response<GetMessageByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetMessageByIdQuery(int id)
        {
            Id = id;
        }
    }
}
