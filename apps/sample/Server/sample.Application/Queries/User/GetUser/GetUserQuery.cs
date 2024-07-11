using sample.Core.Cqrs;
using sample.Shared.Models;
using MediatR;

namespace sample.Application.Queries;

public class GetUserQuery : IRequest<Result<UserDto>>
{
    public required string Id { get; set; }
}
