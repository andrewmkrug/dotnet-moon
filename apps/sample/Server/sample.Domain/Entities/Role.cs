using sample.Domain.Core;
using Microsoft.AspNetCore.Identity;

namespace sample.Domain.Entities;

public class Role : IdentityRole, IEntity<string>
{
    public List<RoleClaim> Claims { get; set; } = [];
}
