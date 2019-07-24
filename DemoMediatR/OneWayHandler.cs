using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatR
{
    public class OneWayHandler : AsyncRequestHandler<OneWay>
    {
        protected override Task Handle(OneWay request, CancellationToken cancellationToken)
        {
            Console.WriteLine(request.Secret);

            return Task.Delay(2000);
        }
    }
}
