using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.OrderDetailQueries;
using Aranoz.Application.Mediator.Results.OrderDetailResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, Response<List<GetOrderDetailQueryResult>>>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetOrderDetailQueryResult>>> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetOrderDetailQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetOrderDetailQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetOrderDetailQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetOrderDetailQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
