using FluentValidation;

namespace RodinaTurkey.Validation
{
    public class CategoryCarValidation : AbstractValidator<RodinaTurkey.Models.Entitiy.Tbl_RentCategory>
    {
        public CategoryCarValidation()
        {
            RuleFor(x => x.RentCategory).NotEmpty().WithMessage("ARAÇ MARKA ADI BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.RentCategory).MaximumLength(70).WithMessage("ARAÇ MARKA ADI 70 KARAKTERDEN FAZLA OLAMAZ !!");
        }
    }
}