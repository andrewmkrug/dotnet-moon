namespace sample.Domain.Core;

public interface IDomainEventHolder
{
    List<IDomainEvent> DomainEvents { get; }
}
