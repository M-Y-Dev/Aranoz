using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BlogCategoryQueries;
using Aranoz.Application.Mediator.Results.BlogCategoryResults;
using Aranoz.Application.Mediator.Results.MessageResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.BlogCategoryHandlers
{
    public class GetBlogCategoryQueryHandler : IRequestHandler<GetBlogCategoryQuery, Response<List<GetBlogCategoryQueryResult>>>
    {
        private readonly IRepository<BlogCategory> _repository;
        private readonly IMapper _mapper;

        public GetBlogCategoryQueryHandler(IRepository<BlogCategory> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetBlogCategoryQueryResult>>> Handle(GetBlogCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetBlogCategoryQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetBlogCategoryQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetBlogCategoryQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetBlogCategoryQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
