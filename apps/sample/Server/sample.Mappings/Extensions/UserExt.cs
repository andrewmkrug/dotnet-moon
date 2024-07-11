using sample.Domain.Entities;
using sample.Shared.Models;

namespace sample.Mappings;

public static class UserExt
{
    private static readonly UserMapper Mapper = new();
    
    public static UserDto ToDto(this User entity)
    {
        return Mapper.ToDto(entity);
    }
    
    public static User ToEntity(this UserDto dto)
    {
        return Mapper.ToEntity(dto);
    }
}
