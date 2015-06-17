using System;
using Messages;
using NServiceBus;

namespace MultiMessageHandler
{
    class FirstHandler: IHandleMessages<ThisMessageWillTrigerMultipleHandlers>
    {
        public IBus Bus { get; set; }
    
        public void Handle(ThisMessageWillTrigerMultipleHandlers message)
        {
            Console.Out.WriteLine("FirstHandler");
            Bus.Reply(new FirstHandlerReply());
        }
    }
}