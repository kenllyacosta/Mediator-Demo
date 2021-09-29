using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator : IMediator
    {
        Assembly HandlerAssembly;
        public Mediator(Assembly handlerAssembly)
        {
            HandlerAssembly = handlerAssembly;
        }

        public Task Send(IRequest request, CancellationToken cancellationToken = default)
        {
            return Handler<Task, IRequest>(request, cancellationToken);
        }

        public Task<ResponseType> Send<ResponseType>(IRequest<ResponseType> request, CancellationToken cancellationToken = default)
        {
            return Handler<Task<ResponseType>, IRequest<ResponseType>>(request, cancellationToken);
        }

        ReturnType Handler<ReturnType, RequestType>(RequestType request, CancellationToken cancellationToken)
        {
            ReturnType Result = default;
            Type RequestHandlerType;

            if (typeof(ReturnType).IsGenericType)
            {
                RequestHandlerType = typeof(IRequestHandler<,>);
            }
            else
            {
                RequestHandlerType = typeof(IRequestHandler<>);
            }

            Type Handler = HandlerAssembly.GetTypes().FirstOrDefault(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == RequestHandlerType
            && i.GetGenericArguments()[0] == request.GetType()));
            if (Handler != null)
            {
                var HandlerInstance = Activator.CreateInstance(Handler);
                Result = (ReturnType)Handler.GetMethod("Handle").Invoke(HandlerInstance, new object[] { request, cancellationToken });
            }
            else
            {
                throw new InvalidOperationException(string.Format("Error, manejador no encontrado {0}", request.GetType()));
            }

            return Result;
        }
    }
}
