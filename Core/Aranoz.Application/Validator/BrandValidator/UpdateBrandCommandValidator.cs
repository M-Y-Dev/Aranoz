using Aranoz.Application.Mediator.Commands.BrandCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BrandValidator
{
    public class UpdateBrandCommandValidator : AbstractValidator<UpdateBrandCommand>
    {
        public UpdateBrandCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş bırakılamaz.");
            RuleFor(x => x.BrandName).NotEmpty().WithMessage("BrandName boş bırakılamaz.");


        }
    }
}
