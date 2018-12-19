using System.Collections.Generic;
namespace CommandStack.Domain
{
    public interface IEventProvider
    {
        void LoadEvents<TEvent>(TEvent events) where TEvent : IEvent;
        IEnumerable<TEvent> GetEvents<TEvent>() where TEvent : IEvent;
        void ClearEvents();
    }
}
