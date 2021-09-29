namespace Notifications
{
    public class PersistenceService
    {
        readonly IMediator Mediator;
        public PersistenceService(IMediator mediator)
            => Mediator = mediator;

        public void SaveChanges()
        {
            Mediator.Publish("SaveChanges");
        }
    }
}
