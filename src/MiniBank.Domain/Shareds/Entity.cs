using System.Collections.Generic;

namespace MiniBank.Domain.Shareds
{
    public abstract class Entity
    {
        private readonly IList<IEvent> _events;

        protected Entity() => _events = new List<IEvent>();
        
        protected void Raise(IEvent @event) => _events.Add(@event);

        public void ClearEvents() => _events.Clear();
    }
}
