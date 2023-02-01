using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_MainDll
{
    public class Accounts
    {
        private string accountno;
        float balance;
        public List<Accounts> beneficiaries;

        public Accounts(string accno)
        {
            this.accountno = accno;
            beneficiaries = new List<Accounts>();
            balance+= 500.0f;
        }
        public float checkBalance()
        {
            return balance;
        }
        public void Deposit(float amt)
        {
            balance += amt;
        }

        public void Withdraw(float amt)
        {
            if (balance > amt)
            {
                balance -= amt;
            }
            else
                throw new Exception("Not Enough Funds to withdraw..");
        }
    }
}
