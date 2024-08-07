using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.AppUserCommands;
using Aranoz.Application.Validator.AppUserValidator;
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

namespace Aranoz.Application.Mediator.Handlers.AppUserHandlers
{
    public class UpdateAppUserCommandHandler : IRequestHandler<UpdateAppUserCommand, Response<object>>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;
        public UpdateAppUserCommandHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<object>> Handle(UpdateAppUserCommand request, CancellationToken cancellationToken)
        {
            UpdateAppUseCommandValidator validationRules = new UpdateAppUseCommandValidator();
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
                response.Message = "Kayıt Eklenirken Sorun Yaşandı";
                return response;
            } 

            var result=_mapper.Map<AppUser>(request); 
            await _repository.UpdateAsync(result);
            return new Response<object>
            {
                StatusCode = (int)HttpStatusCode.Created,
                Data = null,
                IsSuccessfull = true,
                Message = "Kayıt başarıyla Eklendi",
            };
        }
    }
}
