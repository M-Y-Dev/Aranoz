using Aranoz.Application.Mediator.Commands.ProductDetailCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.ProductDetailValidator
{
    public class DeleteProductDetailCommandValidator : AbstractValidator<DeleteProductDetailCommand>
    {
        public DeleteProductDetailCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
        }
    }
}
