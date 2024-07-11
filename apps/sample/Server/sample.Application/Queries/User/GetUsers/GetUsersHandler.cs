using sample.Application.Core;
using sample.Domain.Entities;
using sample.Domain.Persistence;
using sample.Domain.Specifications;
using sample.Mappings;
using sample.Mappings;
using sample.Core.Cqrs;
using sample.Shared.Models;

namespace sample.Application.Queries;

internal class GetUsersHandler : RequestHandler<GetUsersQuery, PagedResult<UserDto>>
{
    private readonly IUnitOfWork _uow;

    public GetUsersHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }
    
    protected override async Task<PagedResult<UserDto>> HandleValidated(
        GetUsersQuery req, CancellationToken ct)
    {
        var totalItems = await _uow.Repository<User>().CountAsync();

        var users = _uow.Repository<User>()
            .ApplySpecification(new GetUsersPaged(req.OrderBy, req.Page, req.PageSize))
            .Select(i => i.ToDto())
            .ToArray();
        
        return PagedResult<UserDto>.Succeed(users, totalItems, req.PageSize);
    }
}
