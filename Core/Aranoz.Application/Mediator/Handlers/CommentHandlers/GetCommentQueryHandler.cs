using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.CommentQueries;
using Aranoz.Application.Mediator.Results.CommentResults;
using Aranoz.Domain.Entity;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.CommentHandlers
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, Response<List<GetCommentQueryResult>>>
    {
        private readonly IRepository<Comment> _repository;
        private readonly IMapper _mapper;

        public GetCommentQueryHandler(IRepository<Comment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<List<GetCommentQueryResult>>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetCommentQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetCommentQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetCommentQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetCommentQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
