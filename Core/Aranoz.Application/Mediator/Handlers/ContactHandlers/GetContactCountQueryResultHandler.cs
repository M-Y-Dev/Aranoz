using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.ContactQueries;
using Aranoz.Application.Mediator.Queries.ProductQueries;
using Aranoz.Application.Mediator.Results.ContactResults;
using Aranoz.Application.Mediator.Results.ProductResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.ContactHandlers
{
    public class GetContactCountQueryResultHandler : IRequestHandler<GetContactCountQuery, Response<GetContactCountQueryResult>>
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;

        public GetContactCountQueryResultHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetContactCountQueryResult>> Handle(GetContactCountQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetCountAsync();
            if (values > 0)
                return new Response<GetContactCountQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Data = _mapper.Map<GetContactCountQueryResult>(values),
                    IsSuccessfull = true,
                    Message = "Ürün sayısı getirildi"
                };
            return new Response<GetContactCountQueryResult>
            {
                StatusCode = (int)HttpStatusCode.NotFound,
                Data = null,
                IsSuccessfull = false,
                Message = "Ürün sayısı getirilemedi"
            };
        }
    }
}
