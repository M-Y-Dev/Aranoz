using Aranoz.Application.Mediator.Commands.BlogCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BlogValidator
{
    public class UpdateBlogCommandValidator : AbstractValidator<UpdateBlogCommand>
    {
        public UpdateBlogCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID boş bırakılamaz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description boş bırakılamaz.");
            RuleFor(x => x.CoverImageUrl).Must(uri => string.IsNullOrEmpty(uri) || Uri.TryCreate(uri, UriKind.Absolute, out _)).WithMessage("Geçerli bir URL giriniz.");
            RuleFor(x => x.BlogCategoryId).NotEmpty().WithMessage("Blog category ID boş bırakılamaz.");
        }
    }
}
