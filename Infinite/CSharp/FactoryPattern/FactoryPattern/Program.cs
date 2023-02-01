using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditcard = new PlatinumFactory().CreateProduct();
            if(creditcard!=null)
            {
                Console.WriteLine("Card Type is  :" + "  "+ creditcard.GetCardType());
                Console.WriteLine("CreditLimit is  :{0}", creditcard.GetCreditLimit());
                Console.WriteLine("Annual Charges are :{0}", creditcard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("-------------");
            creditcard = new TitaniumFactory().CreateProduct();
            if (creditcard != null)
            {
                Console.WriteLine("Card Type is  :" + "  " + creditcard.GetCardType());
                Console.WriteLine("CreditLimit is  :{0}", creditcard.GetCreditLimit());
                Console.WriteLine("Annual Charges are :{0}", creditcard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.WriteLine("--------------------");
            creditcard = new MoneybackFactory().CreateProduct();
            if (creditcard != null)
            {
                Console.WriteLine("Card Type is  :" + "  " + creditcard.GetCardType());
                Console.WriteLine("CreditLimit is  :{0}", creditcard.GetCreditLimit());
                Console.WriteLine("Annual Charges are :{0}", creditcard.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
            Console.Read();
        }
    }
}
