using sample.Domain.Entities;
using sample.Mappings;
using sample.Shared.Models;

namespace sample.Mappings
{
    public partial class UserMapper : IUserMapper
    {
        public UserDto ToDto(User p1)
        {
            return p1 == null ? null : new UserDto()
            {
                Id = p1.Id,
                Email = p1.Email,
                PhoneNumber = p1.PhoneNumber
            };
        }
        public User ToEntity(UserDto p2)
        {
            return p2 == null ? null : new User()
            {
                Id = p2.Id,
                Email = p2.Email,
                PhoneNumber = p2.PhoneNumber
            };
        }
    }
}