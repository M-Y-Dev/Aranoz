using Aranoz.Application.Mediator.Commands.BasketCommands;
using Aranoz.Application.Mediator.Commands.CategoryCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BasketValidator
{
    public class CreateBasketCommandValidator : AbstractValidator<CreateBasketCommand>
    {
        public CreateBasketCommandValidator()
        {
            RuleFor(x => x.AppUserId).NotEmpty().WithMessage("Kullanıcı Boş geçilemez.");

        }
    }
}
