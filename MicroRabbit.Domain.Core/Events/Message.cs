using MediatR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public String MessageType { get; protected set; }
        protected Message()
        {
            MessageType = GetType().Name;

        }
    }
}
