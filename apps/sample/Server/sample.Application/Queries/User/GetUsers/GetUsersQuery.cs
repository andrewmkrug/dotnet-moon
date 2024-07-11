using sample.Core.Cqrs;
using sample.Shared.Models;
using MediatR;

namespace sample.Application.Queries;

public class GetUsersQuery : PagedQuery, IRequest<PagedResult<UserDto>>
{
}
