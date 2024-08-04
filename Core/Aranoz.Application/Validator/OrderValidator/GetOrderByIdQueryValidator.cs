using Aranoz.Application.Mediator.Queries.OrderQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.OrderValidator
{
    public class GetOrderByIdQueryValidator:AbstractValidator<GetOrderByIdQuery>
    {
        public GetOrderByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id boş geçilemez");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id 0 dan büyük olmalıdır");
        }
    }
}
