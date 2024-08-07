using Aranoz.Application.Mediator.Commands.AppUserCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AppUserValidator
{
    public class DeleteAppuserCommandValidator:AbstractValidator<DeleteAppUserCommand> 
    {
        public DeleteAppuserCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id 0 dan büyük olmalıdır");
        }
    }
}
