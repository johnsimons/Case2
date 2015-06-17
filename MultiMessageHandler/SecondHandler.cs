using System;
using Messages;
using NServiceBus;

namespace MultiMessageHandler
{
    class SecondHandler : IHandleMessages<ThisMessageWillTrigerMultipleHandlers>
    {
        public IBus Bus { get; set; }

        public void Handle(ThisMessageWillTrigerMultipleHandlers message)
        {
            Console.Out.WriteLine("SecondHandler");
            Bus.Reply(new SecondHandlerReply());
        }
    }
}