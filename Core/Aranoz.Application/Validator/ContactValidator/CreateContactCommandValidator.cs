using Aranoz.Application.Mediator.Commands.CommentCommands;
using Aranoz.Application.Mediator.Commands.ContactCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.ContactValidator
{
    public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
    {
        public CreateContactCommandValidator()
        {
            RuleFor(x => x.CompleteName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş bırakılamaz.")
                                  .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj içeriği boş bırakılamaz.");
        }
    }
}
