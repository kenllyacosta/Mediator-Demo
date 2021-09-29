using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo
{
    public class PingNotification : INotification
    {
    }

    public class PingNotificationHandler1 : INotificationHandler<PingNotification>
    {
        public Task Handle(PingNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Pong 1");
            return Task.CompletedTask;
        }
    }

    public class PingNotificationHandler2 : INotificationHandler<PingNotification>
    {
        public Task Handle(PingNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Pong 2");
            return Task.CompletedTask;
        }
    }

    public class PingNotificationHandler3 : INotificationHandler<PingNotification>
    {
        public Task Handle(PingNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Pong 3");
            return Task.CompletedTask;
        }
    }

    public class PingNotificationHandler4 : INotificationHandler<PingNotification>
    {
        public Task Handle(PingNotification notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Pong 4");
            return Task.CompletedTask;
        }
    }
}
