using Aranoz.Application.Mediator.Commands.BrandCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BrandValidator
{
    public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandCommandValidator()
        {
            RuleFor(x => x.BrandName).NotEmpty().WithMessage("BrandName Boş Bırakılamaz.");
        }
    }
}
