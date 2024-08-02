using Aranoz.Application.Mediator.Commands.MessageCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.MessageValidator
{
    public class UpdateMessageCommandValidator : AbstractValidator<UpdateMessageCommand>
    {
        public UpdateMessageCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID boş bırakılamaz.");
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Full name boş bırakılamaz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş bırakılamaz.")
                                  .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu boş bırakılamaz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj içeriği boş bırakılamaz.");
        }
    }
}
    }
}
