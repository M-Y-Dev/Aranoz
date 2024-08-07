using Aranoz.Application.Mediator.Commands.AppUserCommands;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aranoz.Application.Validator.AppUserValidator
{
    public class CreateAppUserCommadValidator : AbstractValidator<CreateAppUserCommand>
    {
        public CreateAppUserCommadValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("İsim en az 2 karekter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(15).WithMessage("İsim  en fazla 15 karekter olmalıdır!");
            RuleFor(x => x.Name).Matches("^[a-zA-Z]+$").WithMessage("İsim sadece harf içermelidir!");


            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Boş geçilemez!");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Soyisim en az 2 karekter olmalıdır!");
            RuleFor(x => x.Surname).MaximumLength(15).WithMessage("Soyisim en fazla 15 karekter olmalıdır!");
            RuleFor(x => x.Surname).Matches("^[a-zA-Z]+$").WithMessage("Soyisim sadece harf içermelidir!");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email adressi boş geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen mail formatında veri giriniz!");

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karekter olmalıdır!");
            RuleFor(x => x.UserName).MaximumLength(15).WithMessage("Kullanıcı adı ");
            RuleFor(x => x.UserName).Matches(@"(?=.*[a-zA-Z])(?=.*\d)").WithMessage("Kullanıcı Adı hem harf hem de rakam içermelidir.");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş geçilemez");
            RuleFor(x => x.PhoneNumber).Matches(@"^0\d{3} \d{3} \d{2} \d{2}$").When(x => x.PhoneNumber.StartsWith("0")).WithMessage("Geçerli bir yerel  telefon numarası giriniz.");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim boş geçilemez");

            RuleFor(x => x.RoleId).NotEmpty().WithMessage("Role boş geçilemez");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
            RuleFor(x => x.Password).MinimumLength(8).WithMessage("Şifre en az 8 karekter olmalıdır!");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Şifre fazla  20 karekter olmalıdır!");
            RuleFor(x => x.Password).Matches(@"[A-Z]").WithMessage("Şifre en az 1 harf büyük olmalıdır!");
            RuleFor(x => x.Password).Matches(@"[0-9]").WithMessage("Şifrede en az 1 tane sayı olmalıdır!");
            RuleFor(x => x.Password).Matches(@"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>/?]").WithMessage("Şifre en az bir özel karakter içermelidir.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez");
            RuleFor(x => x.Description).MinimumLength(15).WithMessage("Açıklama en az 15 karekter olmalıdır!");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Açıkalama  en fazla 50 karekter olmalıdır!");

        }
    }
}
