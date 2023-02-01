using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
     class NullableEg
    {
        public static void nullableFunc()
        {
            int ? TicketsOnSale = null; //you are making a value type nullable
            int AvailableTickets;

            if(TicketsOnSale==null)
            {
                AvailableTickets = 0;
            }
            else
            {
               // AvailableTickets =(int)TicketsOnSale; //or
                AvailableTickets = TicketsOnSale.Value;
            }
            Console.WriteLine("Available Tickets ={0}",AvailableTickets);
        }
        /* the below function is used to replace the above functions code
         into a simpler representation using null coalescing operator */
        public void nullcoalescingFunc()
        {
            int ? TicketsOnSale = 200;
            int AvailableTickets = TicketsOnSale ==null ? 0 : (int)TicketsOnSale; //or
            AvailableTickets = TicketsOnSale == null ? 0 : TicketsOnSale.Value; //or
            AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine("Available Tickets is {0}",AvailableTickets);
           
            
          


        }
    }
}
