using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.AppRoleCommands;
using Aranoz.Application.Validator.AppRoleValidator;
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

namespace Aranoz.Application.Mediator.Handlers.AppRoleHandlers
{
    public class UpdateAppRoleCommandHandler : IRequestHandler<UpdateAppRoleCommand, Response<object>>
    {
        private readonly IRepository<AppRole> _repository;
        private readonly IMapper _mapper;
        public UpdateAppRoleCommandHandler(IRepository<AppRole> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<object>> Handle(UpdateAppRoleCommand request, CancellationToken cancellationToken)
        {
           UpdateApproleCommandValidator validationRules = new UpdateApproleCommandValidator(); 
           ValidationResult validation= validationRules.Validate(request);
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
                response.Message = "Kayıt güncellenirken Sorun Yaşandı";
                return response;

            }
            var result = _mapper.Map<AppRole>(request);
            await _repository.UpdateAsync(result);
            return new Response<object>
            {
                StatusCode = (int)HttpStatusCode.Created,
                Data = null,
                IsSuccessfull = true,
                Message = "Kayıt başarıyla güncellendi"
            };
        }
    }
}
