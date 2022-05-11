namespace BlazorServerTestIis.Application.Commands;

public class RobotValidator : AbstractValidator<Robot>
{
    public RobotValidator()
    {
        RuleFor(r => r.Code)
            .NotEmpty()
            .NotEqual("AAA")
            .MinimumLength(5);

        RuleFor(r => r.Power)
            .GreaterThanOrEqualTo(0)
            .Must(nb => nb % 2 == 0).WithMessage("Must be even")
            .LessThan(5000);

        RuleFor(r => r.CyberBrain)
            .NotNull();
    }
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<Robot>.CreateWithOptions((Robot)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
