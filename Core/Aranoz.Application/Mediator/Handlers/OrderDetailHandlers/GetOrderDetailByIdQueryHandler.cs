using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.OrderDetailQueries;
using Aranoz.Application.Mediator.Results.OrderDetailResults;
using Aranoz.Application.Validator.OrderDetailValidator;
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

namespace Aranoz.Application.Mediator.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler : IRequestHandler<GetOrderDetailByIdQuery, Response<GetOrderDetailByIdQueryResult>>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetOrderDetailByIdQueryResult>> Handle(GetOrderDetailByIdQuery request, CancellationToken cancellationToken)
        {
            GetOrderDetailByIdQueryValidator validationRules = new GetOrderDetailByIdQueryValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetOrderDetailByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetOrderDetailByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }

            var value = await _repository.GetSingleByIdAsync(request.Id);

            if (value is null)
                return new Response<GetOrderDetailByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt bulunamadı"
                };
            return new Response<GetOrderDetailByIdQueryResult>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = _mapper.Map<GetOrderDetailByIdQueryResult>(value),
                IsSuccessfull = true,
                Message = "Kayıt başarıyla getirildi"
            };
        }
    }
}
