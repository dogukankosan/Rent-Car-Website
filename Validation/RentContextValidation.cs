using FluentValidation;
using RodinaTurkey.Models.Entitiy;

namespace RodinaTurkey.Validation
{
    public class RentContextValidation : AbstractValidator<Tbl_RentContent>
    {
        public RentContextValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("YORUM YAPAN İSİM BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("YORUM YAPAN MAİL BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.ContextText).NotEmpty().WithMessage("YORUM İÇERİĞİ BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("YORUM YAPAN İSİM 50 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Mail).MaximumLength(70).WithMessage("YORUM YAPAN MAİL 70 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.ContextText).MaximumLength(500).WithMessage("YORUM İÇERİĞİ 500 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Image).MaximumLength(200).WithMessage("RESİM 200 KARAKTERDEN FAZLA OLAMAZ !!");
        }
    }
}