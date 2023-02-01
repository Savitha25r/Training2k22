using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Dotnet
{
    public class AccessSpecifiersEg
    {
        public int publicmember;
        int privatemember;
        internal int internalmember;
        protected int protectedmember;
        internal protected int internalp;

        public void checkAccess()
        {
            publicmember = 1;
            privatemember = 2;
            internalmember = 3;
            protectedmember = 4;
            internalp = 5;
            Console.WriteLine(" Project 1 Assembly function.. ");
        }
    }

    class TestAccess : AccessSpecifiersEg
    {
        public void TestingAccess()
        {
            AccessSpecifiersEg aeg = new AccessSpecifiersEg();
            aeg.publicmember = 10;
            aeg.internalmember = 20;
            aeg.internalp = 30;
            TestAccess ta = new TestAccess();
            ta.publicmember = 15;
            ta.internalmember = 25;
            ta.protectedmember = 35;
            ta.internalp = 45;
        }
    }

    class Checker
    {
        public void Check()
        {
            AccessSpecifiersEg access = new AccessSpecifiersEg();
            access.publicmember = 1;
            access.internalmember = 2;
            access.internalp = 3;

        }

           
    }
}
