using Aranoz.Application.Mediator.Commands.AddressCommands;
using Aranoz.Application.Mediator.Commands.ProductCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AddressValidator
{
    public class UpdateAddressCommandValidator : AbstractValidator<UpdateAddressCommand>
    {
        public UpdateAddressCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Ülke adı boş bırakılamaz.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir adı  boş bırakılamaz.");
            RuleFor(x => x.AddressDetail).NotEmpty().WithMessage("Adres Detayı boş bırakılamaz.");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş bırakılamaz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail Adresi boş bırakılamaz.");
        }
    }
}
