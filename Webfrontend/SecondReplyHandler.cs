using System;
using Messages;
using NServiceBus;

namespace Webfrontend
{
    class SecondReplyHandler : IHandleMessages<SecondHandlerReply>
    {
        public void Handle(SecondHandlerReply message)
        {
            Console.Out.WriteLine("SecondHandlerReply");
        }
    }
}