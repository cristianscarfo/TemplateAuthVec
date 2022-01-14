using AuthVec.Domain.Common;

namespace AuthVec.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
