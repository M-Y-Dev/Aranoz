using Aranoz.Application.Mediator.Commands.AppRoleCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AppRoleValidator
{
  public class DeleteAppRoleCommandValidator:AbstractValidator<DeleteAppRoleCommand>
    {
        public DeleteAppRoleCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez.");

        }
    }
}
