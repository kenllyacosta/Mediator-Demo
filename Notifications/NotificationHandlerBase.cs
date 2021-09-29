using System.Diagnostics;

namespace Notifications
{
    public abstract class NotificationHandlerBase : INotificationHandler
    {
        public virtual void Handler(string message)
        {
            Debug.WriteLine($"{this.GetType()} => {message}");
        }
    }
}