using System;

using Day4Dotnet;

namespace Day4DotNet_Prj2
{
    class Prj2_Program : AccessSpecifiersEg
    {
        static void Main(string[] args)
        {
            AccessSpecifiersEg prj2access = new AccessSpecifiersEg();
            prj2access.publicmember = 500;
            Console.WriteLine(prj2access.publicmember);
            prj2access.checkAccess();
           
            Console.WriteLine("Hi Project 2");
            Prj2_Program prj2 = new Prj2_Program();
            prj2.publicmember = 50;
            prj2.protectedmember = 60;
            prj2.internalp = 70;
            Console.Read();
        }
    }

    class Outsider
    {
        public void outsiderfunc()
        {
            AccessSpecifiersEg a = new AccessSpecifiersEg();
            a.publicmember = 8;
        }
    }
}
