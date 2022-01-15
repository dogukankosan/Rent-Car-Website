using FluentValidation;
using RodinaTurkey.Models.Entitiy;

namespace RodinaTurkey.Validation
{
    public class AboutValidation : AbstractValidator<Tbl_Abouts>
    {
        public AboutValidation()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("İSMİNİZİ BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("ŞİRKET ADI BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("RESMİNİZİ BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.CompanyImage).NotEmpty().WithMessage("ŞİRKET RESMİNİZİ BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.UserName).MaximumLength(70).WithMessage("İSMİNİZ 70 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Image).MaximumLength(200).WithMessage("RESMİNİZ 200 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.CompanyName).MaximumLength(500).WithMessage("ŞİRKET ADI 500 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.CompanyImage).MaximumLength(200).WithMessage("RESMİNİZ 200 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Mail).MaximumLength(50).WithMessage("MAİL 50 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("MAİL BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.Phone).MaximumLength(15).WithMessage("TELEFON 15 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("TELEFON NO BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.Adress).MaximumLength(200).WithMessage("ADRES 200 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Adress).NotEmpty().WithMessage("ADRES BOŞ GEÇMEYİNİZ !!");
            RuleFor(x => x.Video).MaximumLength(200).WithMessage("TANITIM VİDEOSU 200 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Video).NotEmpty().WithMessage("TANITIM VİDEOSU BOŞ GEÇİLEMEZ !!");
        }
    }
}