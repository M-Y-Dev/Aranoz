using Aranoz.Application.Base;
using Aranoz.Application.Interfaces;
using Aranoz.Application.Mediator.Commands.CommentCommands;
using Aranoz.Application.Mediator.Commands.CommentCommands;
using Aranoz.Application.Validator.CommentValidator;
using Aranoz.Domain.Entity;
using AutoMapper;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Mediator.Handlers.CommentHandlers
{
    public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Response<object>>
    {
        private readonly IRepository<Comment> _repository;
        private readonly IMapper _mapper;

        public CreateCommentCommandHandler(IRepository<Comment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Response<object>> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            CreateCommentCommandValidator validationRules = new CreateCommentCommandValidator();
            ValidationResult validation = validationRules.Validate(request);
            if (!validation.IsValid)
            {
                var response = new Response<object>();
                foreach (var item in validation.Errors)
                {
                    response.Errors.Add(item.ErrorMessage.ToString());
                }

                response.StatusCode = 400;
                response.Data = null;
                response.IsSuccessfull = false;
                response.Message = "Kayıt eklenirken sorun yaşandı.";
                return response;
            }

            var result = _mapper.Map<Comment>(request);
            await _repository.CreateAsync(result);

            return new Response<object>
            {
                StatusCode = (int)HttpStatusCode.Created,
                Data = null,
                IsSuccessfull = true,
                Message = "Kayıt başarıyla eklendi",
            };
        }
    }
}
