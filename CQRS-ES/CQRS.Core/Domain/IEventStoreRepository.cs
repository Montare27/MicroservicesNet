﻿namespace CQRS.Core.Domain;

using Events;

public interface IEventStoreRepository
{
	Task SaveAsync(EventModel @event);

	Task<List<EventModel>> FindByAggregateId(Guid aggregateId);
}
