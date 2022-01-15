using FluentValidation;
using RodinaTurkey.Models.Entitiy;

namespace RodinaTurkey.Validation
{
    public class SalesValidation : AbstractValidator<Tbl_SalesList>
    {
        public SalesValidation()
        {
            RuleFor(x => x.OneFiveDay).NotEmpty().WithMessage("1-5 GÜNLÜK FİYAT BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.FiveFifftenDay).NotEmpty().WithMessage("5-15 GÜNLÜK FİYAT BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.FifftenThrisDay).NotEmpty().WithMessage("15-30 GÜNLÜK FİYAT BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.ThirsdayPlus).NotEmpty().WithMessage("+30 GÜNLÜK FİYAT BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.FiveFifftenDay).MaximumLength(7).WithMessage("5-15 GÜNLÜK FİYAT 7 HANE FAZLA OLAMAZ !!");
            RuleFor(x => x.OneFiveDay).MaximumLength(7).WithMessage("1-5 GÜNLÜK FİYAT 7 HANE FAZLA OLAMAZ !!");
            RuleFor(x => x.ThirsdayPlus).MaximumLength(7).WithMessage("+30 GÜNLÜK FİYAT 7 HANE FAZLA OLAMAZ !!");
            RuleFor(x => x.FifftenThrisDay).MaximumLength(7).WithMessage("15-30 GÜNLÜK FİYAT 7 HANE FAZLA OLAMAZ !!");
        }
    }
}