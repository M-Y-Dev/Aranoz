using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BasketItemQueries;
using Aranoz.Application.Mediator.Queries.BasketQueries;
using Aranoz.Application.Mediator.Results.BasketItemResults;
using Aranoz.Application.Mediator.Results.BasketResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.BasketItemHandlers
{
    public class GetBasketItemQueryResultHandler : IRequestHandler<GetBasketItemQuery, Response<List<GetBasketItemQueryResult>>>
    {
        private readonly IRepository<BasketItem> _repository;
        private readonly IMapper _mapper;

        public GetBasketItemQueryResultHandler(IRepository<BasketItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetBasketItemQueryResult>>> Handle(GetBasketItemQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetBasketItemQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetBasketItemQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetBasketItemQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetBasketItemQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
