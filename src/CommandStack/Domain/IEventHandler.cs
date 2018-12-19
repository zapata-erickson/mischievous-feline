using System;
namespace CommandStack.Domain
{
    public interface IEventHandler<TEvent> where TEvent : IEvent
    {
        void HandleEvent(TEvent @event);
    }
}
