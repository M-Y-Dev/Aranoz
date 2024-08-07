using Aranoz.Application.Mediator.Commands.BlogCategoryCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BlogCategoryValidator
{
    public class CreateBlogCategoryCommandValidator:AbstractValidator<CreateBlogCategoryCommand>
    {
        public CreateBlogCategoryCommandValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category name boş bırakılamaz.");
        }
    }
}
