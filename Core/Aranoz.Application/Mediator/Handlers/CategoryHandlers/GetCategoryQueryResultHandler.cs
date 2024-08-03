using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.CategoryQueries;
using Aranoz.Application.Mediator.Results.CategoryResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryQueryResultHandler : IRequestHandler<GetCategoryQuery, Response<List<GetCategoryQueryResult>>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryResultHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<List<GetCategoryQueryResult>>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetCategoryQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetCategoryQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetCategoryQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetCategoryQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
