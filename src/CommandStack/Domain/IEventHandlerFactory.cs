using System;
namespace CommandStack.Domain
{
    public interface IEventHandlerFactory
    {
        IEventHandler<TEvent> GetEventHandler<TEvent>() where TEvent : IEvent;
    }
}
