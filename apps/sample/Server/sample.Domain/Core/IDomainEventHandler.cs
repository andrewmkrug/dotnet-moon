using MediatR;

namespace sample.Domain.Core;

public interface IDomainEventHandler<in T> : INotificationHandler<T> where T : IDomainEvent
{
}
