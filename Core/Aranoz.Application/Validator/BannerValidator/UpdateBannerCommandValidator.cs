using Aranoz.Application.Mediator.Commands.BannerCommands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.BannerValidator
{
    public class UpdateBannerCommandValidator : AbstractValidator<UpdateBannerCommand>
    {
        public UpdateBannerCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("ID boş bırakılamaz.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image URL boş bırakılamaz.")
                                    .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).WithMessage("Geçerli bir URL giriniz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description boş bırakılamaz.");
        }
    }
}
    }
}
