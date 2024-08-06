using Aranoz.Application.Mediator.Queries.BrandQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BrandValidator
{
    public class GetBrandByIdQueryValidator : AbstractValidator<GetBrandByIdQuery>
    {
        public GetBrandByIdQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
        }
    }
}
