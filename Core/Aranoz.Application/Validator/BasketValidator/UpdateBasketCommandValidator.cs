using Aranoz.Application.Mediator.Commands.BasketCommands;
using Aranoz.Application.Mediator.Commands.OrderCommands;
using Aranoz.Application.Mediator.Queries.BasketQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BasketValidator
{
    public class UpdateBasketCommandValidator : AbstractValidator<UpdateBasketCommand>
    {
        public UpdateBasketCommandValidator()
        {
            RuleFor(x => x.AppUserId).NotEmpty().WithMessage("Kullanıcı Boş geçilemez.");
        }
    }
}
