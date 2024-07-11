using sample.Application.Core;
using sample.Domain.Entities;
using sample.Domain.Persistence;
using sample.Mappings;
using sample.Core.Cqrs;
using sample.Shared.Models;

namespace sample.Application.Queries;

internal class GetUserHandler : RequestHandler<GetUserQuery, Result<UserDto>>
{
    private readonly IUnitOfWork _uow;

    public GetUserHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }
    
    protected override async Task<Result<UserDto>> HandleValidated(
        GetUserQuery req, CancellationToken ct)
    {
        var userEntity = await _uow.Repository<User>().GetAsync(i => i.Id == req.Id);

        if (userEntity is null)
        {
            return Result<UserDto>.Fail($"Could not find a user with ID {req.Id}");
        }

        var userDto = userEntity.ToDto();
        return Result<UserDto>.Succeed(userDto);
    }
}
