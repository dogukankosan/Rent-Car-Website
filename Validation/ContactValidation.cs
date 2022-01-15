using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using RodinaTurkey.Models.Entitiy;

namespace RodinaTurkey.Validation
{
    public class ContactValidation:AbstractValidator<Tbl_Contact>
    {
        public ContactValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İSMİNİZİ BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("MAİL BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("MESAJ KONU BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.ContentText).NotEmpty().WithMessage("MESAJ İÇERİK BOŞ GEÇEMEZSİNİZ !!");
            RuleFor(x => x.Name).MaximumLength(70).WithMessage("İSMİNİZ 70 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Mail).MaximumLength(70).WithMessage("MAİL 70 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.Subject).MaximumLength(200).WithMessage("MESAJ KONU 200 KARAKTERDEN FAZLA OLAMAZ !!");
            RuleFor(x => x.ContentText).MaximumLength(1000).WithMessage("MESAJ İÇERİĞİ 1000 KARAKTERDEN FAZLA OLAMAZ !!");
        }
    }
}