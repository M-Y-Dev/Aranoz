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
    public class GetBannerByIdQuery : IRequest<Response<GetBannerByIdQueryResult>>
    {
        public int Id { get; set; }

        public GetBannerByIdQuery(int id)
        {
            Id = id;
        }
    }
}
