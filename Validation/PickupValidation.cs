using FluentValidation;
using RodinaTurkey.Models.Entitiy;

namespace RodinaTurkey.Validation
{
    public class PickupValidation : AbstractValidator<Tbl_Pickup>
    {
        public PickupValidation()
        {
            RuleFor(x => x.PickupLocation).NotEmpty().WithMessage("KONUM BOŞ GEÇİLEMEZ !!");
            RuleFor(x => x.PickupLocation).MaximumLength(200).WithMessage("KONUM 200 KARAKTERDEN FAZLA OLAMAZ !!");
        }
    }
}