using sample.Core.Cqrs;
using MediatR;

namespace sample.Application.Commands;

public class DeleteUserCommand : IRequest<Result>
{
    public string? Id { get; set; }
}
