using Aranoz.Application.Base;
using Aranoz.Application.Mediator.Results.AppRoleResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Queries.AppRoleQueries
{
    public class GetAppRoleByIdQuery:IRequest<Response<GetAppRoleByIdQueryResult>>
    { 
        public int Id { get; set; }

        public GetAppRoleByIdQuery(int id)
        {
            Id = id;
        }
    }
}
