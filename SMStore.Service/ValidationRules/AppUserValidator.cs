using FluentValidation; // FluentValidation ı kullanabilmek için
using SMStore.Entities;

namespace SMStore.Service.ValidationRules
{
    public class AppUserValidator : AbstractValidator<AppUser> // AbstractValidator FluentValidation ın kontrol sınıfıdır
    {
        public AppUserValidator()
        {
            // Burada constructor da validasyon kurallarını belirliyoruz
            RuleFor(x=>x.Name).NotEmpty(); // Kontrol ettiğimiz AppUser classının Name özelliğinin boş olmaması gerektiğini belirttik
            RuleFor(x => x.Surname).NotNull(); // Soyadı boş olamaz
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Boş Bırakılamaz!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Email Boş Bırakılamaz!").MinimumLength(3).WithMessage("Şifre Minimum 3 Karakter Olmalıdır!");
            // Burada RuleFor ile tüm kurallarımızı koyduktan sonra bu AppUserValidator classını Program.cs de servis olarak tanımlıyoruz.
        }
    }
}
