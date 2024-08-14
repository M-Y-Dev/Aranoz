using Aranoz.Application.Mediator.Queries.OrderDetailQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.OrderDetailValidator
{
    public class GetOrderDetailByIdQueryValidator : AbstractValidator<GetOrderDetailByIdQuery>
    {
        public GetOrderDetailByIdQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");
        }

    }
}
