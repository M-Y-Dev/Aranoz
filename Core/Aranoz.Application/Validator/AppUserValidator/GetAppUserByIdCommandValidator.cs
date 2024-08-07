using Aranoz.Application.Mediator.Queries.AppUserQueries;
using Aranoz.Application.Mediator.Results.AppUserResults;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AppUserValidator
{
  public class GetAppUserByIdCommandValidator:AbstractValidator<GetAppUserByIdQuery>
    {
        public GetAppUserByIdCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id 0 dan büyük olmalıdır");
        }
    }
}
