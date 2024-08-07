﻿using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.AddressCommands;
using Aranoz.Application.Validator.AddressValidator;
using Aranoz.Domain.Entity;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.AddressHandlers
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, Response<object>>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async  Task<Response<object>> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            CreateAddressCommandValidator validationRules = new CreateAddressCommandValidator();
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

            var result = _mapper.Map<Address>(request);
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
