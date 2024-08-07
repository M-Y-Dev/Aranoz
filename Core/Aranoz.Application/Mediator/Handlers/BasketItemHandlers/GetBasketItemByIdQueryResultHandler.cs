using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BasketItemQueries;
using Aranoz.Application.Mediator.Results.BasketItemResults;
using Aranoz.Application.Mediator.Results.BasketResults;
using Aranoz.Application.Validator.BasketItemValidator;
using Aranoz.Application.Validator.BasketValidator;
using Aranoz.Domain.Entity;
using AutoMapper;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.BasketItemHandlers
{
    public class GetBasketItemByIdQueryResultHandler : IRequestHandler<GetBasketItemByIdQuery, Response<GetBasketItemByIdQueryResult>>
    {
        private readonly IRepository<BasketItem> _repository;
        private readonly IMapper _mapper;

        public GetBasketItemByIdQueryResultHandler(IRepository<BasketItem> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetBasketItemByIdQueryResult>> Handle(GetBasketItemByIdQuery request, CancellationToken cancellationToken)
        {
            GetBasketItemByIdQueryValidator validationRules = new GetBasketItemByIdQueryValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetBasketItemByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetBasketItemByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }

            var value = await _repository.GetById(request.Id);

            if (value is null)
                return new Response<GetBasketItemByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt bulunamadı"
                };
            return new Response<GetBasketItemByIdQueryResult>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = _mapper.Map<GetBasketItemByIdQueryResult>(value),
                IsSuccessfull = true,
                Message = "Kayıt başarıyla getirildi"
            };
        }
    }
}
