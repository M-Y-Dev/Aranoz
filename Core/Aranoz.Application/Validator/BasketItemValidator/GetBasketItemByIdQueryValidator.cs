using Aranoz.Application.Mediator.Queries.BasketItemQueries;
using Aranoz.Application.Mediator.Queries.OrderQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BasketItemValidator
{
    public class GetBasketItemByIdQueryValidator : AbstractValidator<GetBasketItemByIdQuery>
    {
        public GetBasketItemByIdQueryValidator()
        {
            RuleFor(x => x.Id)
      .GreaterThan(0).WithMessage("Id 0'dan büyük olmalıdır.");
        }
    }
}
