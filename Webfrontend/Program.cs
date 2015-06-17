using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using NServiceBus;

namespace Webfrontend
{
    class Program
    {
        static void Main(string[] args)
        {
            BusConfiguration busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("WebFrontend");
            busConfiguration.UseSerialization<XmlSerializer>();
            busConfiguration.EnableInstallers();
            busConfiguration.UsePersistence<InMemoryPersistence>();

            using (IStartableBus bus = Bus.Create(busConfiguration))
            {
                bus.Start();

                Console.Out.WriteLine("Press key to start");
                Console.Read();

                bus.Send(new ThisMessageWillTrigerMultipleHandlers());
            }
        }
    }
}
