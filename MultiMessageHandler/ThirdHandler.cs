using System;
using Messages;
using NServiceBus;

namespace MultiMessageHandler
{
    class ThirdHandler : IHandleMessages<ThisMessageWillTrigerMultipleHandlers>
    {
        public IBus Bus { get; set; }

        public void Handle(ThisMessageWillTrigerMultipleHandlers message)
        {
            Console.Out.WriteLine("ThirdHandler");
            Bus.Reply(new ThirdHandlerReply());
        }
    }
}