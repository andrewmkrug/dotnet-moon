using Microsoft.AspNetCore.Identity;

namespace sample.Domain.Entities;

public class RoleClaim : IdentityRoleClaim<string>
{
    public Role? Role { get; set; }
}
