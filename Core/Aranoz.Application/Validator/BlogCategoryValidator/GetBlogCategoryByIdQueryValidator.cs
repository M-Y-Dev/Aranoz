using Aranoz.Application.Mediator.Queries.BlogCategoryQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BlogCategoryValidator
{
    public class GetBlogCategoryByIdQueryValidator : AbstractValidator<GetBlogCategoryByIdQuery>
    {
        public GetBlogCategoryByIdQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id Boş Bırakılmaz.");
        }
    }
}

