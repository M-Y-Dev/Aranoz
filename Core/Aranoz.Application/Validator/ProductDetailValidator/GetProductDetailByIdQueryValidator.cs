using Aranoz.Application.Mediator.Queries.ProductDetailQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.ProductDetailValidator
{
    public class GetProductDetailByIdQueryValidator : AbstractValidator<GetProductDetailByIdQuery>
    {
        public GetProductDetailByIdQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
        }
    }
}
