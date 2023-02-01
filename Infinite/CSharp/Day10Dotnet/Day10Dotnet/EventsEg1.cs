using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Dotnet
{
    public delegate string Mydelegate(string str);
    class EventsEg1
    {
        //declare an event associated to a delegate
        event Mydelegate myevent; //decl an event of a particular delegate type
        public EventsEg1()
        {
            this.myevent += new Mydelegate(this.WelcomeUser);
            this.myevent += new Mydelegate(this.Secondfunc);
            
        }

        public string WelcomeUser(string uname)
        {
            return "Welcome User" + " " + uname;
        }

        public string Secondfunc(string s)
        {
            Console.WriteLine(WelcomeUser(s)); 
            return s + " " + "Hope you are enjoying the Event";
        }

        static void Main()
        {
            EventsEg1 eventseg = new EventsEg1();
            string welcomemsg = eventseg.myevent("Infinite"); //raising the event
            Console.WriteLine(welcomemsg);
            Console.Read();
        }
    }
}
