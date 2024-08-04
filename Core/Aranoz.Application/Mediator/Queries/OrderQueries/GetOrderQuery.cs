using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.OrderResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.OrderQueries
{
    public class GetOrderQuery:IRequest<Response<List<GetOrderQueryResult>>>
    {
    }
}
