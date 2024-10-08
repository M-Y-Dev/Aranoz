﻿using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.BannerCommands;
using Aranoz.Application.Validator.BannerValidator;
using Aranoz.Domain.Entity;
using AutoMapper;
using FluentValidation.Results;
using MediatR;
using System.Net;

namespace Aranoz.Application.Mediator.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler : IRequestHandler<CreateBannerCommand, Response<object>>
    {
        private readonly IRepository<Banner> _repository;
        private readonly IMapper _mapper;

        public CreateBannerCommandHandler(IRepository<Banner> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<object>> Handle(CreateBannerCommand request, CancellationToken cancellationToken)
        {
            CreateBannerCommandValidator validationRules = new CreateBannerCommandValidator();
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
            var result = _mapper.Map<Banner>(request);
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
