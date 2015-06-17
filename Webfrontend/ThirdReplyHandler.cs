using System;
using Messages;
using NServiceBus;

namespace Webfrontend
{
    class ThirdReplyHandler : IHandleMessages<ThirdHandlerReply>
    {
        public void Handle(ThirdHandlerReply message)
        {
            Console.Out.WriteLine("ThirdHandlerReply");
        }
    }
}