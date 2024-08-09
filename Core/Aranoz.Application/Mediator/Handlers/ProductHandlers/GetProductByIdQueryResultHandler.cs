using Aranoz.Application.Base;
using FluentValidation.Results;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.ProductQueries;
using Aranoz.Application.Mediator.Results.ProductResults;
using Aranoz.Application.Validator.ProductValidator;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.ProductHandlers
{
    public class GetProductByIdQueryResultHandler : IRequestHandler<GetProductByIdQuery, Response<GetProductByIdQueryResult>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryResultHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<GetProductByIdQueryResult>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            GetProductByIdQueryValidator validationRules = new GetProductByIdQueryValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetProductByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetProductByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }

            var value = await _repository.GetSingleByIdAsync(request.Id);

            if (value is null)
                return new Response<GetProductByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt bulunamadı"
                };
            return new Response<GetProductByIdQueryResult>
            {
               StatusCode = (int)HttpStatusCode.OK,
               Data = _mapper.Map<GetProductByIdQueryResult>(value),
               IsSuccessfull = true,
               Message = "Kayıt başarıyla getirildi"
            };

        }
    }
}
