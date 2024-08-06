using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.AppUserResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.AppUserQueries
{
    public class GetAppUserQuery:IRequest<Response<List<GetAppUserQueryResult>>>
    {
    }
}
