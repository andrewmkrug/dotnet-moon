using FluentValidation;

namespace sample.Application.Queries;

internal class GetUserValidator : AbstractValidator<GetUserQuery>
{
    public GetUserValidator()
    {
        RuleFor(i => i.Id).NotEmpty();
    }
}
