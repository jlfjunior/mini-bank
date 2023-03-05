using FluentValidation;

namespace MiniBank.Application.Commands.Validator
{
    public class CreateAccountCommandValidator : AbstractValidator<CreateAccountCommand>
    {
        public CreateAccountCommandValidator()
        {
            RuleFor(x => x.UserId)
                .GreaterThan(0);

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty();
        }
    }
}
