using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.AppRoleQueries;
using Aranoz.Application.Mediator.Results.AppRoleResults;
using Aranoz.Application.Mediator.Results.AppUserResults;
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
    public class GetAppRoleByIdQueryHandler : IRequestHandler<GetAppRoleByIdQuery, Response<GetAppRoleByIdQueryResult>>
    {
        private readonly IRepository<AppRole> _repository;
        private readonly IMapper _mapper;
        public GetAppRoleByIdQueryHandler(IRepository<AppRole> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetAppRoleByIdQueryResult>> Handle(GetAppRoleByIdQuery request, CancellationToken cancellationToken)
        {
           GetAppRoleByIdCommandValidator validationRules= new GetAppRoleByIdCommandValidator(); 
            ValidationResult validation=validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetAppRoleByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetAppRoleByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }

            var values = _repository.GetSingleByIdAsync(request.Id);

            if (values is null)
                return new Response<GetAppRoleByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt bulunamadı"
                };
            return new Response<GetAppRoleByIdQueryResult>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = _mapper.Map<GetAppRoleByIdQueryResult>(values),
                IsSuccessfull = true,
                Message = "Kayıt başarıyla getirildi"
            };
        }
    }
}
