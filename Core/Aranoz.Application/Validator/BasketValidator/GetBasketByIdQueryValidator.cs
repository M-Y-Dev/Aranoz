using Aranoz.Application.Mediator.Queries.BasketQueries;
using Aranoz.Application.Mediator.Queries.OrderQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BasketValidator
{
    public class GetBasketByIdQueryValidator : AbstractValidator<GetBasketByIdQuery>
    {
        public GetBasketByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez");

        }
    }
}
