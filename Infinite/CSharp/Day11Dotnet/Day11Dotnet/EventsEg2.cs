using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Dotnet
{
    class EventsEg2
    {
        int data = 5;
        public delegate void numbermanipulator(int x);

        public event numbermanipulator changenum;

        public EventsEg2(int n)
        {
            this.changenum += new numbermanipulator(this.OnChangenum);
            setvalue(n);
        }

        public void OnChangenum(int x)
        {            
            Console.WriteLine($"Event raised and the value from {data} is changed to {x}");
            data = x;
        }

        public void setvalue(int n) //responsible for raising an event
        {
            if(data!=n)
            {
                changenum(n);
            }
            else
            {
                Console.WriteLine("No Changes in the Value.. No Event");
            }
        }
        
    }

    class TestEvent
    {
        static void Main(string[] args)
        {
            EventsEg2 eventseg2 = new EventsEg2(5);
            eventseg2.setvalue(15);
            eventseg2.setvalue(20);
            eventseg2.setvalue(5);
            eventseg2.setvalue(5);
            Console.Read();
        }
    }
}
