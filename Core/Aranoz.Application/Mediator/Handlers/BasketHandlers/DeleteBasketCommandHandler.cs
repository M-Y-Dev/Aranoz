using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.BasketCommands;
using Aranoz.Application.Mediator.Commands.BasketCommands;
using Aranoz.Application.Validator.BasketValidator;
using Aranoz.Domain.Entity;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.BasketHandlers
{
    public class DeleteBasketCommandHandler : IRequestHandler<DeleteBasketCommand, Response<object>>
    {
        private readonly IRepository<Basket> _repository;

        public DeleteBasketCommandHandler(IRepository<Basket> repository)
        {
            _repository = repository;
        }

        public async Task<Response<object>> Handle(DeleteBasketCommand request, CancellationToken cancellationToken)
        {
            DeleteBasketCommandValidator validationRules = new DeleteBasketCommandValidator();
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

            var value = await _repository.GetSingleByIdAsync(request.Id);

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
                Data = null,
                IsSuccessfull = true,
                Message = "Kayıt silindi",
            };
        }
    }
}
