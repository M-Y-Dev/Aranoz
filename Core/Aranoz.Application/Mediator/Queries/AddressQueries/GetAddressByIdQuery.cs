using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.AddressResults;
using Aranoz.Application.Mediator.Results.ProductResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.AddressQueries
{
    public class GetAddressByIdQuery : IRequest<Response<GetAddressByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}
