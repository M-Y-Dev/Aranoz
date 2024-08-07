﻿using Aranoz.Application.Mediator.Commands.BannerCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BannerValidator
{
    public class DeleteBannerCommandValidator : AbstractValidator<DeleteBannerCommand>
    {
        public DeleteBannerCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id Boş Bırakılmaz.");
        }
    }
}
