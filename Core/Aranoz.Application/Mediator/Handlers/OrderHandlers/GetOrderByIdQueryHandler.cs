using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.OrderQueries;
using Aranoz.Application.Mediator.Results.AppRoleResults;
using Aranoz.Application.Mediator.Results.OrderResults;
using Aranoz.Application.Validator.OrderValidator;
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

namespace Aranoz.Application.Mediator.Handlers.OrderHandlers
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, Response<GetOrderByIdQueryResult>>
    {
        private readonly IRepository<Order> _repository;
        private readonly IMapper _mapper;
        public GetOrderByIdQueryHandler(IRepository<Order> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetOrderByIdQueryResult>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            GetOrderByIdQueryValidator validationRules = new GetOrderByIdQueryValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetOrderByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetOrderByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }

            var values = _repository.GetById(request.Id);

            if (values is null)
                return new Response<GetOrderByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt bulunamadı"
                };
            return new Response<GetOrderByIdQueryResult>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = _mapper.Map<GetOrderByIdQueryResult>(values),
                IsSuccessfull = true,
                Message = "Kayıt başarıyla getirildi"
            };
        }
    }
}
