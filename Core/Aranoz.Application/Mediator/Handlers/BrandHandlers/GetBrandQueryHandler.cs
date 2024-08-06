using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BrandQueries;
using Aranoz.Application.Mediator.Results.BrandResults;
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

namespace Aranoz.Application.Mediator.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, Response<List<GetBrandQueryResult>>>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public GetBrandQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetBrandQueryResult>>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetBrandQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetBrandQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetBrandQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetBrandQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
