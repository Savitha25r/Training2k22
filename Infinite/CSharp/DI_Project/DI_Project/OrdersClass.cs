using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    class OrdersClass :IOrders
    {         
          public void DisplayOrders()
            {
                Console.WriteLine("Displaying the Orders..");
            }
        
    }
}
