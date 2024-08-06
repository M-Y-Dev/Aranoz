using Aranoz.Application.Mediator.Commands.ProductDetailCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.ProductDetailValidator
{
    public class CreateProductDetailCommandValidator : AbstractValidator<CreateProductDetailCommand>
    {
        public CreateProductDetailCommandValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("ProductName boş bırakılamaz.");
            RuleFor(x => x.BrandName).NotEmpty().WithMessage("BrandName boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description boş bırakılamaz.");
            RuleFor(x => x.Rating).InclusiveBetween(1, 5).WithMessage("Rating 1 ile 5 arasında olmalıdır.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("ImageUrl boş bırakılamaz.");
        }
    }
}
