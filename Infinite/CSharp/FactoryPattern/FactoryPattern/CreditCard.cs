using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharges();
    }

    public class Moneyback : CreditCard
    {
        public int GetAnnualCharges()
        {
            return 600;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }

    public class Titanium : CreditCard
    {
        public int GetAnnualCharges()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }

    public class Platinum : CreditCard
    {
        public int GetAnnualCharges()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
