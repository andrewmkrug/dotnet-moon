using sample.Application.Core;
using sample.Domain.Entities;
using sample.Domain.Persistence;
using sample.Core.Cqrs;

namespace sample.Application.Commands;

internal class CreateUserHandler : RequestHandler<CreateUserCommand, Result>
{
    private readonly IUnitOfWork _uow;

    public CreateUserHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }
    
    protected override async Task<Result> HandleValidated(
        CreateUserCommand req, CancellationToken ct)
    {
        var newUser = User.Create(req.Email!, req.PhoneNumber!);
        
        
        await _uow.Repository<User>().AddAsync(newUser);
        await _uow.SaveChangesAsync(ct);
        return Result.Succeed();
    }
}
