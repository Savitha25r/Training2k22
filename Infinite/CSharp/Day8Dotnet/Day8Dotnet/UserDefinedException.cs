using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Dotnet
{
    //userdefined exception class
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg)
        {

        }
    }
    class Vote
    {
        int age;
        public void acceptAge()
        {
            Console.WriteLine("Enter Age :");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<=18)
            {
                throw (new VotingException("Age Should be Greater Than 18 to Vote."));
            }
            else
                Console.WriteLine("Thanks for Voting..");
        }
    }
    class UserDefinedException
    {
        static void Main()
        {
            Vote v = new Vote();
            try
            {
                v.acceptAge();
            }
            catch (VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }
            Console.Read();
        }
    }
}
