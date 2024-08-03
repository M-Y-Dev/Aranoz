using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aranoz.Application.Mediator.Commands.CategoryCommands;
using FluentValidation;

namespace Aranoz.Application.Validator.CategoryValidator
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz.");
        }
    }
}
