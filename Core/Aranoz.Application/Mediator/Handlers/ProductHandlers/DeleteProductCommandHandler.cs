using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using FluentValidation.Results;
using Aranoz.Application.Mediator.Commands.ProductCommands;
using Aranoz.Application.Validator.ProductValidator;
using Aranoz.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.ProductHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Response<object>>
    {
        private readonly IRepository<Product> _repository;

        public DeleteProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<Response<object>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            DeleteProductCommandValidator validationRules = new DeleteProductCommandValidator();
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
                response.Message = "Kayıt silinirken sorun yaşandı.";
                return response;
            }

            var value = await _repository.GetById(request.Id);

            if (value is null)
                return new Response<object>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Silinecek kayıt bulunamadı"
                };

            await _repository.DeleteAsync(request.Id);
            return new Response<object>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = "Kayıt silindi",
                IsSuccessfull = true,
                Message = null,
            };

        }
    }
}
