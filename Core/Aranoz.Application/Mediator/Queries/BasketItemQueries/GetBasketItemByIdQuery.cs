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
    public class GetBasketItemByIdQuery : IRequest<Response<GetBasketItemByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetBasketItemByIdQuery(int id)
        {
            Id = id;
        }
    }
}
