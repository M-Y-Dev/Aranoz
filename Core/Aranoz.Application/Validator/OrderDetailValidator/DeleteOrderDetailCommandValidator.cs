using Aranoz.Application.Mediator.Commands.OrderDetailCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.OrderDetailValidator
{
    public class DeleteOrderDetailCommandValidator : AbstractValidator<DeleteOrderDetailCommand>
    {
        public DeleteOrderDetailCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
        }
    }
}
