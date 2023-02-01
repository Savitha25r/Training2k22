using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace Remoting
{
    public class RemotingServer
    {
        public RemotingServer()
        {

        }
    }

    //service class
    public class Service : MarshalByRefObject
    {
        public int WriteMessage(int n1, int n2)
        {
            int maxval=(Math.Max(n1,n2));
            Console.WriteLine("Call Executed...");
            return maxval;
        }
    }

    //server class

    class Server
    {
        static void Main(string[] args)
        {
            //create a new channel
            HttpChannel c = new HttpChannel(86);
            //register the created channel
            ChannelServices.RegisterChannel(c);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "OurService",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services Started at Port No. 86......");
            Console.WriteLine("Press any Key to Stop the Server...");
            Console.Read();
        }
    }
}
