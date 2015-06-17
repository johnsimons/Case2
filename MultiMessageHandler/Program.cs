using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace MultiMessageHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            BusConfiguration busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("MultiMessageHandler");
            busConfiguration.UseSerialization<XmlSerializer>();
            busConfiguration.EnableInstallers();
            busConfiguration.UsePersistence<InMemoryPersistence>();
            busConfiguration.LoadMessageHandlers<First<AuthenticationHandler>>();

            using (IStartableBus bus = Bus.Create(busConfiguration))
            {
                bus.Start();

                Console.Out.WriteLine("Press key to stop");
                Console.Read();
            }
        }
    }
}
