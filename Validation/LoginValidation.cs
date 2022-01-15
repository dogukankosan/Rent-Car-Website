using FluentValidation;
using RodinaTurkey.Models.Entitiy;

namespace RodinaTurkey.Validation
{
    public class LoginValidation : AbstractValidator<Tbl_Login>
    {
        public LoginValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("LÜTFEN KULLANICI ADINIZ BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("LÜTFEN ŞİFRENİZİ BOŞ BIRAKMAYINIZ");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("LÜTFEN 50 KARAKTERDEN FAZLA GİRİŞ YAPMAYINIZ !!");
            RuleFor(x => x.Password).MaximumLength(50).WithMessage("LÜTFEN 50 KARAKTERDEN FAZLA GİRİŞ YAPMAYINIZ !!");
        }
    }
}