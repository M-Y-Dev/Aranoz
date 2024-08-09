using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.ProductResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.ProductQueries
{
    public class GetProductFilterCountQuery:IRequest<Response<GetProductFilterCountQueryResult>>
    {
    }
}
