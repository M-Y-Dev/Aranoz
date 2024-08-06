using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.ProductDetailQueries;
using Aranoz.Application.Mediator.Results.CommentResults;
using Aranoz.Application.Mediator.Results.ProductDetailResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.ProductDetailHandlers
{
    public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, Response<List<GetProductDetailQueryResult>>>
    {
        private readonly IRepository<ProductDetail> _repository;
        private readonly IMapper _mapper;

        public GetProductDetailQueryHandler(IRepository<ProductDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetProductDetailQueryResult>>> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetProductDetailQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetProductDetailQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetProductDetailQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetProductDetailQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
