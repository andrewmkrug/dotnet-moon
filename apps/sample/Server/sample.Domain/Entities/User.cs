using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using sample.Domain.Core;
using Microsoft.AspNetCore.Identity;

namespace sample.Domain.Entities;

public class User : IdentityUser, IAuditableEntity<string>, IDomainEventHolder
{
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    
    [NotMapped, JsonIgnore] 
    public List<IDomainEvent> DomainEvents { get; } = [];
    
    public static User Create(string email, string phoneNumber)
    {
        var newUser = new User
        {
            Email = email,
            PhoneNumber = phoneNumber
        };
        
        return newUser;
    }
}
