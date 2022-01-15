using FluentValidation;

namespace RodinaTurkey.Validation
{
    public class RentCarValidation : AbstractValidator<RodinaTurkey.Models.Entitiy.Tbl_Rentcar>
    {
        public RentCarValidation()
        {
            RuleFor(x => x.Sales).NotEmpty().WithMessage("ARAÇ FİYAT BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.About).MaximumLength(500).WithMessage("ARAÇ HAKKINDA 500 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.About).NotEmpty().WithMessage("ARAÇ HAKKINDA KISMINI BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.CarName).NotEmpty().WithMessage("ARAÇ MODEL BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.CarImage).NotEmpty().WithMessage("ARAÇ RESİM BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.CarName).MaximumLength(150).WithMessage("ARAÇ MODEL 150 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.CarImage).MaximumLength(200).WithMessage("ARAÇ RESİM 200 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Oil).NotEmpty().WithMessage("YAKIT TİPİ BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.Oil).MaximumLength(10).WithMessage("YAKIT TİPİ 10 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Gerbox).NotEmpty().WithMessage("ŞANZIMAN TİPİNİ BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.Gerbox).MaximumLength(10).WithMessage("ŞANZIMAN TİPİ 10 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Km).NotEmpty().WithMessage("KM BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.Km).MaximumLength(10).WithMessage("KM 7 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.ChairCount).NotEmpty().WithMessage("KOLTUK SAYISI BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.ChairCount).MaximumLength(10).WithMessage("KOLTUK SAYISI 1 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Luggage).NotEmpty().WithMessage("KAPI SAYISI BOŞ BIRAKMAYINIZ !!");
            RuleFor(x => x.Luggage).MaximumLength(10).WithMessage("KAPI SAYISI 1 KARAKTERDEN FAZLA OLAMAZ !!");
        }
    }
}