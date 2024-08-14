using Aranoz.Application.Mediator.Commands.OrderDetailCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.OrderDetailValidator
{
    public class UpdateOrderDetailCommandValidator : AbstractValidator<UpdateOrderDetailCommand>
    {
        public UpdateOrderDetailCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("Sipariş boş bırakılamaz.");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Ürün boş bırakılamaz.");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Adet boş bırakılamaz.");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Adet Fiyatı boş bırakılamaz.");
        }

    }
}
