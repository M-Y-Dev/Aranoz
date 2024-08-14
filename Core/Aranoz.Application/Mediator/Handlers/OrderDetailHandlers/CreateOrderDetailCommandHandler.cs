using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.OrderDetailCommands;
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
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand, Response<object>>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<object>> Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            CreateOrderDetailCommandValidator validationRules = new CreateOrderDetailCommandValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<object>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = null;
                response.IsSuccessfull = false;
                response.Message = "Kayıt eklenirken sorun yaşandı.";
                return response;
            }

                var result = _mapper.Map<OrderDetail>(request);
                await _repository.CreateAsync(result);

            
                return new Response<object>
                {
                    StatusCode = (int)HttpStatusCode.Created,
                    Data = null,
                    IsSuccessfull = true,
                    Message = "Kayıt başarıyla eklendi",
                };

        }
    }
}
