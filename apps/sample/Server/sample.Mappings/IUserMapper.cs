using sample.Domain.Entities;
using sample.Shared.Models;
using Mapster;

namespace sample.Mappings;

[Mapper]
public interface IUserMapper
{
    UserDto ToDto(User entity);
    User ToEntity(UserDto dto);
}
