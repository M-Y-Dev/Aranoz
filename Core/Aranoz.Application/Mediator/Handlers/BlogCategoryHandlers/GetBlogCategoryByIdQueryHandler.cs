using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BlogCategoryQueries;
using Aranoz.Application.Mediator.Results.BlogCategoryResults;
using Aranoz.Application.Mediator.Results.CommentResults;
using Aranoz.Application.Validator.BlogCategoryValidator;
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

namespace Aranoz.Application.Mediator.Handlers.BlogCategoryHandlers
{
    public class GetBlogCategoryByIdQueryHandler : IRequestHandler<GetBlogCategoryByIdQuery, Response<GetBlogCategoryByIdQueryResult>>
    {
        private readonly IRepository<BlogCategory> _repository;
        private readonly IMapper _mapper;
        public GetBlogCategoryByIdQueryHandler(IRepository<BlogCategory> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetBlogCategoryByIdQueryResult>> Handle(GetBlogCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            GetBlogCategoryByIdQueryValidator validationRules = new GetBlogCategoryByIdQueryValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<GetBlogCategoryByIdQueryResult>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = new GetBlogCategoryByIdQueryResult();
                response.IsSuccessfull = false;
                response.Message = "Kayıt getirilirken sorun yaşandı.";
                return response;
            }
            var value = await _repository.GetSingleByIdAsync(request.Id);
            if (value is null)
                return new Response<GetBlogCategoryByIdQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Data = null,
                    IsSuccessfull = false,
                    Message = "Kayıt Bulunmadı"
                };
            return new Response<GetBlogCategoryByIdQueryResult>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Data = _mapper.Map<GetBlogCategoryByIdQueryResult>(value),
                IsSuccessfull = true,
                Message = "Kayıt Başarıyla Getirildi"
            };



        }
    }
}
