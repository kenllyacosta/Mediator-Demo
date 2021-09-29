using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo
{
    public class Ping : IRequest<string>
    {

    }

    //Solo acepta un Handler
    //public class PingHandler : IRequestHandler<Ping, string>
    //{
    //    public Task<string> Handle(Ping request, CancellationToken cancellationToken)
    //    {
    //        return Task.FromResult("Pong");
    //    }
    //}

    public class PingHandler2 : IRequestHandler<Ping, string>
    {
        public Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong 2");
        }
    }
}
