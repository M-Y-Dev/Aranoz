using Aranoz.Application.Base;
using FluentValidation.Results;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.ProductCommands;
using Aranoz.Application.Validator.ProductValidator;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Response<object>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public  async Task<Response<object>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            CreateProductCommandValidator validationRules = new CreateProductCommandValidator();
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

            var result = _mapper.Map<Product>(request);
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
