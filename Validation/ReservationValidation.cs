using FluentValidation;
using RodinaTurkey.Models.Entitiy;

namespace RodinaTurkey.Validation
{
    public class ReservationValidation : AbstractValidator<Tbl_Reservation>
    {
        public ReservationValidation()
        {
            RuleFor(x => x.PickupDropID).NotEmpty().WithMessage("ARACIN BIRAKILACAĞI ADRES BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.PickupAdressID).NotEmpty().WithMessage("ARACIN ALINACAK ADRESİ BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.CarID).NotEmpty().WithMessage("ARAÇ BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("İSMİNİZİ SOYİSMİNİZİ BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.ContentText).NotEmpty().WithMessage("İLETİŞİM KUTUSU BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.FirstDate).NotEmpty().WithMessage("ARACIN ALINACAĞI BAŞLANGIÇ TARİHİ BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.LastDate).NotEmpty().WithMessage("ARACIN BIRAKALICAĞI BİTİŞ TARİHİ BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("TELEFONUZU BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("MAİLİNİZİ BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.NameSurname).MaximumLength(100).WithMessage("ADINIZ SOYADINIZ 100 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Phone).MaximumLength(15).WithMessage("TELEFONUZ 15 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Mail).MaximumLength(70).WithMessage("MAİLİNİZ 70 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.ContentText).MaximumLength(500).WithMessage("İLETİŞİM KUTUSU 500 KARAKTERDEN FAZLA OLAMAZ !!");
        }
    }
}