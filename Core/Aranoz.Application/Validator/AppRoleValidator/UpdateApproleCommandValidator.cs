using Aranoz.Application.Mediator.Commands.AppRoleCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AppRoleValidator
{
    public class UpdateApproleCommandValidator:AbstractValidator<UpdateAppRoleCommand>
    {
        public UpdateApproleCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez");
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Role boş geçilemez.");

        }
    }
}
