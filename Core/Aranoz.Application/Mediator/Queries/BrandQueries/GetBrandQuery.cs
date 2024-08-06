using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.BrandResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.BrandQueries
{
    public class GetBrandQuery : IRequest<Response<List<GetBrandQueryResult>>>
    {
    }
}
