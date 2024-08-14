using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.OrderDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.OrderDetailQueries
{
    public class GetOrderDetailQuery : IRequest<Response<List<GetOrderDetailQueryResult>>>
    {
    }
}
