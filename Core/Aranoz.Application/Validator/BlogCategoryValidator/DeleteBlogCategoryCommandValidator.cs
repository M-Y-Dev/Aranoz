using Aranoz.Application.Mediator.Commands.BlogCategoryCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BlogCategoryValidator
{
    public class DeleteBlogCategoryCommandValidator : AbstractValidator<DeleteBlogCategoryCommand>
    {
        public DeleteBlogCategoryCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id Boş Bırakılmaz.");
        }
    }
}
