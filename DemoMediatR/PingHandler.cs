using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatR
{
    public class PingHandler : IRequestHandler<Ping, string>
    {
        public Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong");
        }
    }
}
