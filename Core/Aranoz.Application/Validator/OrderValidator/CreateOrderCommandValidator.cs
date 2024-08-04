using Aranoz.Application.Mediator.Commands.OrderCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.OrderValidator
{
    public class CreateOrderCommandValidator:AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(x => x.AppUserId).NotEmpty().WithMessage("Kullanıcı Boş geçilemez.");
            RuleFor(x => x.TotalPrice).GreaterThanOrEqualTo(0).WithMessage("Girdiğiniz tutar 0 dan büyük olmalıdır!");
            RuleFor(x => x.TotalPrice).NotEmpty().WithMessage("Toplam fiyat boş geçilemez");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Adet Fiyat boş geçilemez");
            RuleFor(x => x.UnitPrice).GreaterThanOrEqualTo(1).WithMessage("Adet fiyatı 1 den küçük olamaz!");
            RuleFor(x => x.OrderDate).NotEmpty().WithMessage("Tarih boş geçilemez");
        }
    }
}
