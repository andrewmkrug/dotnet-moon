using sample.Domain.Core;

namespace sample.Domain.Events;

internal class UserCreatedEvent : IDomainEvent
{
    public required string UserId { get; set; }
    public required string Email { get; set; }
}
