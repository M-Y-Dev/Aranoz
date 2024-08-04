using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BasketQueries;
using Aranoz.Application.Mediator.Queries.BasketQueries;
using Aranoz.Application.Mediator.Results.BasketResults;
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

namespace Aranoz.Application.Mediator.Handlers.BasketHandlers
{
    public class GetBasketQueryResultHandler : IRequestHandler<GetBasketQuery, Response<List<GetBasketQueryResult>>>
    {
        private readonly IRepository<Basket> _repository;
        private readonly IMapper _mapper;

        public GetBasketQueryResultHandler(IRepository<Basket> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetBasketQueryResult>>> Handle(GetBasketQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetBasketQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetBasketQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetBasketQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetBasketQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
