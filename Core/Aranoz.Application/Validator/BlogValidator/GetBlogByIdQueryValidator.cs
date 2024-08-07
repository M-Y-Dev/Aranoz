using Aranoz.Application.Mediator.Queries.BlogQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BlogValidator
{
    public class GetBlogByIdQueryValidator : AbstractValidator<GetBlogByIdQuery>
    {
        public GetBlogByIdQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id Boş Bırakılmaz.");
        }
    }
}

