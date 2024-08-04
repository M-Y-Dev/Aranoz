﻿using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.BasketResults;
using Aranoz.Application.Mediator.Results.CategoryResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.BasketQueries
{
    public class GetBasketByIdQuery : IRequest<Response<GetBasketByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetBasketByIdQuery(int id)
        {
            Id = id;
        }
    }
}
