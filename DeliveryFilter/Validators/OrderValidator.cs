using DeliveryFilter.Models;
using FluentValidation;

namespace DeliveryFilter.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.Weight).GreaterThan(0).WithMessage("Weight must be greater than zero.");
            RuleFor(o => o.District).NotEmpty().WithMessage("District cannot be null or empty.");
            RuleFor(o => o.DeliveryTime).GreaterThanOrEqualTo(DateTime.Now).WithMessage("DeliveryTime must be in the future.");
        }
    }
}
