using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.BasketItemResults;
using Aranoz.Application.Mediator.Results.BasketResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.BasketItemQueries
{
    public class GetBasketItemQuery : IRequest<Response<List<GetBasketItemQueryResult>>>
    {
    }
}
