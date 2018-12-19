using System;
namespace CommandStack.Domain
{
    public interface IEvent : IDisposable
    {
        Guid EventId { get; }
        DateTime OccuredAt { get; }
    }
}
