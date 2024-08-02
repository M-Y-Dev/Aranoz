using Aranoz.Application.Mediator.Commands.CommentCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.CommentValidator
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Full name boş bırakılamaz.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone boş bırakılamaz.")
                                  .Matches(@"^\+?\d+$").WithMessage("Geçerli bir telefon numarası giriniz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email boş bırakılamaz.")
                                  .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
            RuleFor(x => x.Rating).InclusiveBetween(1, 5).WithMessage("Rating 1 ile 5 arasında olmalıdır.");
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Yorum içeriği boş bırakılamaz.");
        }
    }
}
