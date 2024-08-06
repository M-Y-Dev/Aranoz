using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.ProductDetailQueries;
using Aranoz.Application.Mediator.Results.CommentResults;
using Aranoz.Application.Mediator.Results.ProductDetailResults;
using Aranoz.Application.Validator.CommentValidator;
using Aranoz.Application.Validator.ProductDetailValidator;
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

namespace Aranoz.Application.Mediator.Handlers.ProductDetailHandlers
{
    public class GetProductDetailByIdQueryHandler : IRequestHandler<GetProductDetailByIdQuery, Response<GetProductDetailByIdQueryResult>>
    {
        private readonly IRepository<ProductDetail> _repository;
        private readonly IMapper _mapper;

        public GetProductDetailByIdQueryHandler(IRepository<ProductDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetProductDetailByIdQueryResult>> Handle(GetProductDetailByIdQuery request, CancellationToken cancellationToken)
        {
            GetProductDetailByIdQueryValidator validationRules = new GetProductDetailByIdQueryValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetProductDetailByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetProductDetailByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }

            var value = await _repository.GetById(request.Id);

            if (value is null)
                return new Response<GetProductDetailByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt bulunamadı"
                };
            return new Response<GetProductDetailByIdQueryResult>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = _mapper.Map<GetProductDetailByIdQueryResult>(value),
                IsSuccessfull = true,
                Message = "Kayıt başarıyla getirildi"
            };
        }
    }
}
