using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.BannerResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.BannerQueries
{
    public class GetBannerQuery : IRequest<Response<List<GetBannerQueryResult>>>
    {
    }
}
