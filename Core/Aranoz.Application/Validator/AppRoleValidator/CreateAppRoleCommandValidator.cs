using Aranoz.Application.Mediator.Commands.AppRoleCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AppRoleValidator
{
    public class CreateAppRoleCommandValidator:AbstractValidator<CreateAppRoleCommand>
    {
        public CreateAppRoleCommandValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Role boş geçilemez.");
        }
    }
}
