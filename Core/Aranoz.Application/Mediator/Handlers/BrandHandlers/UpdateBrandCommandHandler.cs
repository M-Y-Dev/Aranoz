using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.BrandCommands;
using Aranoz.Application.Validator.BrandValidator;
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

namespace Aranoz.Application.Mediator.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, Response<object>>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public UpdateBrandCommandHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<object>> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            UpdateBrandCommandValidator validationRules = new UpdateBrandCommandValidator();
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
