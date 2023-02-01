using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using Remoting;

namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel c1 = new HttpChannel(8002);
            ChannelServices.RegisterChannel(c1);
            //create a service class object
            Service service = (Service)Activator.GetObject(typeof(Service),
                "http://localhost:86/OurService");
            //start calling the functions thru the service object
            Console.WriteLine(service.WriteMessage(2, 20)); 
            Console.Read();
        }
    }
}
