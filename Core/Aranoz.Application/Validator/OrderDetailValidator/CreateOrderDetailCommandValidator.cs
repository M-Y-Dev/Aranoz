using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aranoz.Application.Mediator.Commands.OrderDetailCommands;
using FluentValidation;

namespace Aranoz.Application.Validator.OrderDetailValidator
{
    public class CreateOrderDetailCommandValidator : AbstractValidator<CreateOrderDetailCommand>
    {
        public CreateOrderDetailCommandValidator()
        {
            RuleFor(x => x.OrderId).NotEmpty().WithMessage("Sipariş boş bırakılamaz.");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Ürün boş bırakılamaz.");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Adet boş bırakılamaz.");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Adet Fiyatı boş bırakılamaz.");
        }
    }
}
