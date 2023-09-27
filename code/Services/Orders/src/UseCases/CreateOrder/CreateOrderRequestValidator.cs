using FluentValidation;

namespace eShopping.Orders.UseCases.CreateOrder;

public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest>
{
    public CreateOrderRequestValidator()
    {
        RuleFor(x => x.OrderDate)
            .NotEmpty()
            .WithMessage("Order date is required");

        RuleFor(x => x.CustomerId)
            .NotEmpty()
            .WithMessage("Customer id is required");

        RuleFor(o => o.PaymentMethod)
            .Must(x => x.Equals("cash", StringComparison.OrdinalIgnoreCase) || x.Equals("credit", StringComparison.OrdinalIgnoreCase))
            .WithMessage("Payment method must be cash or credit");
    }
}
