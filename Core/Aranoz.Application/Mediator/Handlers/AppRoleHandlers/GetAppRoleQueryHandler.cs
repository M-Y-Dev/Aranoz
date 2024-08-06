using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Queries.AppRoleQueries;
using Aranoz.Application.Mediator.Results.AppRoleResults;
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

namespace Aranoz.Application.Mediator.Handlers.AppRoleHandlers
{
    public class GetAppRoleQueryHandler : IRequestHandler<GetAppRoleQuery, Response<List<GetAppRoleQueryResult>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;
        public GetAppRoleQueryHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAppRoleQueryResult>>> Handle(GetAppRoleQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            if (values.Any())
                return new Response<List<GetAppRoleQueryResult>>
                {
                    IsSuccessfull = true,
                    Data = _mapper.Map<List<GetAppRoleQueryResult>>(values),
                    Message = "Kayıtlar başarıyla getirildi",
                    StatusCode = (int)HttpStatusCode.OK,
                };
            return new Response<List<GetAppRoleQueryResult>>
            {
                IsSuccessfull = false,
                Data = _mapper.Map<List<GetAppRoleQueryResult>>(values),
                Message = "Listelenecek kayıt bulunamadı",
                StatusCode = (int)HttpStatusCode.NotFound,
            };
        }
    }
}
