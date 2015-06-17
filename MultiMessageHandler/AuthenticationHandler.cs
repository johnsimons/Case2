using System;
using NServiceBus;

namespace MultiMessageHandler
{
    class AuthenticationHandler: IHandleMessages<object>
    {
        public void Handle(object message)
        {
            Console.Out.WriteLine("Message is authenticated");
        }
    }
}