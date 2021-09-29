using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IRequestHandler<RequestType> where RequestType : IRequest
    {
        Task Handler(RequestType request, CancellationToken cancellationToken);
    }

    public interface IRequestHandler<RequestType, ResponseType> where RequestType : IRequest<ResponseType>
    {
        Task<ResponseType> Handler(RequestType request, CancellationToken cancellationToken);
    }
}
