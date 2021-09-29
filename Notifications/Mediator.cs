using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Notifications
{
    public class Mediator : IMediator
    {
        readonly IEnumerable<INotificationHandler> Handlers;
        public Mediator(IEnumerable<INotificationHandler> handlers)
            => (Handlers) = (handlers);

        public void Publish(string message)
        {
            Handlers.ToList().ForEach(h => h.Handler(message));
        }
    }
}
