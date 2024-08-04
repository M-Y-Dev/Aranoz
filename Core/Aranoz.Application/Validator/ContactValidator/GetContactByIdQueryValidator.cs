using Aranoz.Application.Mediator.Queries.ContactQueries;
using Aranoz.Application.Mediator.Queries.MessageQueries;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.ContactValidator
{
    public class GetContactByIdQueryValidator : AbstractValidator<GetContactByIdQuery>
    {
        public GetContactByIdQueryValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id boş bırakılamaz.");

        }
    }
}
