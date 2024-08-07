using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.BannerQueries;
using Aranoz.Application.Mediator.Results.BannerResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System.Net;

namespace Aranoz.Application.Mediator.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler : IRequestHandler<GetBannerQuery, Response<List<GetBannerQueryResult>>>
    {
        private readonly IRepository<Banner> _repository;
        private readonly IMapper _mapper;

        public GetBannerQueryHandler(IRepository<Banner> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetBannerQueryResult>>> Handle(GetBannerQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetBannerQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetBannerQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetBannerQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetBannerQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
