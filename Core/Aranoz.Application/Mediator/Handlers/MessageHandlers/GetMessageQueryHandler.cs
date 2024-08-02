using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.MessageQueries;
using Aranoz.Application.Mediator.Results.MessageResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.MessageHandlers
{
    public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, Response<List<GetMessageQueryResult>>>
    {
        private readonly IRepository<Message> _repository;
        private readonly IMapper _mapper;

        public GetMessageQueryHandler(IRepository<Message> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<List<GetMessageQueryResult>>> Handle(GetMessageQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetMessageQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetMessageQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetMessageQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetMessageQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
