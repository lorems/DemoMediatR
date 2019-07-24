using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatR
{
    public class OneWay : IRequest {

        public OneWay(int secret)
        {
            this.Secret = secret;
        }
        public int Secret { get; set; }

    }
}
