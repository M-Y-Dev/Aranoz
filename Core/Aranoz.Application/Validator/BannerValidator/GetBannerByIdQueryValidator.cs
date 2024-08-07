using Aranoz.Application.Mediator.Queries.BannerQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BannerValidator
{
    public class GetBannerByIdQueryValidator : AbstractValidator<GetBannerByIdQuery>
    {
        public GetBannerByIdQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
        }
    }
}
