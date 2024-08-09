using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.ProductQueries;
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

namespace Aranoz.Application.Mediator.Handlers.ProductHandlers
{
    public class GetProductFilterCountQueryResultHandler : IRequestHandler<GetProductFilterCountQuery, Response<GetProductFilterCountQueryResult>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductFilterCountQueryResultHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<GetProductFilterCountQueryResult>> Handle(GetProductFilterCountQuery request, CancellationToken cancellationToken)
        {
            //categoryid si 1 olanların sayısını getir.
            var values = await _repository.GetCountAsync(filter:x=>x.CategoryID == 1);
            if (values > 0)
                return new Response<GetProductFilterCountQueryResult>
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Data = _mapper.Map<GetProductFilterCountQueryResult>(values),
                    IsSuccessfull = true,
                    Message = "Ürün sayısı getirildi"
                };
            return new Response<GetProductFilterCountQueryResult>
            {
                StatusCode = (int)HttpStatusCode.NotFound,
                Data = null,
                IsSuccessfull = false,
                Message = "Ürün sayısı getirilemedi"
            };
        }
    }
}
