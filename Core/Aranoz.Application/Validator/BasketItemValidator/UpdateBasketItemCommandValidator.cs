using Aranoz.Application.Mediator.Commands.BannerCommands;
using Aranoz.Application.Mediator.Commands.BasketItemCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BasketItemValidator
{
    public class UpdateBasketItemCommandValidator : AbstractValidator<UpdateBasketItemCommand>
    {
        public UpdateBasketItemCommandValidator()
        {
            RuleFor(x => x.Id)
           .GreaterThan(0).WithMessage("Id 0'dan büyük olmalıdır.");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("ProductId boş geçilemez.");

            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("ProductName boş bırakılamaz.");

            RuleFor(x => x.Quantity)
                .NotEmpty().WithMessage("Miktar boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Miktar 0'dan büyük olmalıdır.");

            RuleFor(x => x.UnitPrice)
                .NotEmpty().WithMessage("Unit Price boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Unit Price 0'dan büyük olmalıdır.");

            RuleFor(x => x.TotalPrice)
                .NotEmpty().WithMessage("Toplam boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Toplam fiyat 0'dan büyük olmalıdır.");
        }
    }
}
