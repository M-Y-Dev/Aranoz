using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BrandQueries;
using Aranoz.Application.Mediator.Results.BrandResults;
using Aranoz.Application.Mediator.Results.CommentResults;
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
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, Response<GetBrandByIdQueryResult>>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;
        public GetBrandByIdQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetBrandByIdQueryResult>> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            GetBrandByIdQueryValidator validationRules = new GetBrandByIdQueryValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetBrandByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetBrandByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }
            var value = await _repository.GetById(request.Id);
            if (value is null)
                return new Response<GetBrandByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt Bulunmadı"
                };
            return new Response<GetBrandByIdQueryResult>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = _mapper.Map<GetBrandByIdQueryResult>(value),
                IsSuccessfull = true,
                Message = "Kayıt Başarıyla Getirildi"
            };



        }
    }
}
