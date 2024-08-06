using Aranoz.Application.Mediator.Queries.AppRoleQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AppRoleValidator
{
    public class GetAppRoleByIdCommandValidator:AbstractValidator<GetAppRoleByIdQuery>
    {
        public GetAppRoleByIdCommandValidator()
        {
        RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez.");

        }
    }
}
