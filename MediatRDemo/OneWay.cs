using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo
{
    public class OneWay : IRequest
    {
    }

    public class OneWayHandler : AsyncRequestHandler<OneWay>
    {
        protected override Task Handle(OneWay request, CancellationToken cancellationToken)
        {
            Debug.WriteLine("One Way...");
            return Task.CompletedTask;
        }
    }
}
