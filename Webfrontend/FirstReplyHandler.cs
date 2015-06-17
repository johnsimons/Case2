using System;
using Messages;
using NServiceBus;

namespace Webfrontend
{
    class FirstReplyHandler : IHandleMessages<FirstHandlerReply>
    {
        public void Handle(FirstHandlerReply message)
        {
            Console.Out.WriteLine("FirstHandlerReply");
        }
    }
}