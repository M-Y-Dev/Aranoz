﻿using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.BlogCommands;
using Aranoz.Application.Validator.BlogValidator;
using Aranoz.Application.Validator.CommentValidator;
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

namespace Aranoz.Application.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, Response<object>>
    {
        private readonly IRepository<Blog> _repository;
        private readonly IMapper _mapper;

        public UpdateBlogCommandHandler(IRepository<Blog> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<object>> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            UpdateBlogCommandValidator validationRules = new UpdateBlogCommandValidator();
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
                response.Message = "Kayıt güncellenirken sorun yaşandı.";
                return response;
            }

            var value = await _repository.GetById(request.Id);
            if (value is null)
                return new Response<object>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Aranılan kayıt bulunamadı"
                };

            _mapper.Map(request, value);
            await _repository.UpdateAsync(value);

            return new Response<object>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = null,
                IsSuccessfull = true,
                Message = "Kayıt güncellendi"
            };
        }
    }
}
