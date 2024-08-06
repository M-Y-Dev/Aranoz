using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.ProductDetailResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.ProductDetailQueries
{
    public class GetProductDetailQuery : IRequest<Response<List<GetProductDetailQueryResult>>>
    {
    }
}
