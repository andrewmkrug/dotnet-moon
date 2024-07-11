using FluentValidation;

namespace sample.Application.Commands;

internal class DeleteUserValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserValidator()
    {
        RuleFor(i => i.Id)
            .NotEmpty();
    }
}
