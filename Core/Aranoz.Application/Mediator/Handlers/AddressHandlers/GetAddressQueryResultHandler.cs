using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.AddressQueries;
using Aranoz.Application.Mediator.Queries.ProductQueries;
using Aranoz.Application.Mediator.Results.AddressResults;
using Aranoz.Application.Mediator.Results.ProductResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.AddressHandlers
{
    public class GetAddressQueryResultHandler : IRequestHandler<GetAddressQuery, Response<List<GetAddressQueryResult>>>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetAddressQueryResultHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAddressQueryResult>>> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetAddressQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetAddressQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetAddressQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetAddressQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
