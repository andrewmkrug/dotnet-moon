using FluentValidation;

namespace sample.Application.Commands;

internal class UpdateUserValidator : AbstractValidator<UpdateUserCommand>
{
    public UpdateUserValidator()
    {
        RuleFor(i => i.Id)
            .NotEmpty();
    }
}
