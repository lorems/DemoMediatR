using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatR
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            services
                .AddMediatR(Assembly.GetExecutingAssembly());
                //.AddMediatR(typeof(OneWayHandler));

            var provider = services.BuildServiceProvider();
            var mediator = provider.GetRequiredService<IMediator>();

            var response = await mediator.Send(new Ping());

            await mediator.Send(new OneWay(42));

            Console.WriteLine("Hello");
            Console.WriteLine(response); // "Pong"
            Console.WriteLine("Hello World!");
        }
    }   
}
