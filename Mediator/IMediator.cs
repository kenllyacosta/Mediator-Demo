﻿using System.Threading;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        Task Send(IRequest request, CancellationToken cancellationToken = default);
        Task<ResponseType> Send<ResponseType>(IRequest<ResponseType> request, CancellationToken cancellationToken = default);
    }
}
