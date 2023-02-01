using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2DotNet
{
    class DecisionMaking
    {
        public void CheckGrade()
        {
            char grade;
            Console.WriteLine("enter grade :");
            grade = Convert.ToChar(Console.ReadLine());
            if(grade=='O')    
                Console.WriteLine("outstanding");
            else if(grade=='A')
                Console.WriteLine("Excellent");
            else if (grade == 'B')
                Console.WriteLine("VeryGood");
            else if (grade == 'C')
                Console.WriteLine("Good");
            else if (grade == 'D')
                Console.WriteLine("Poor");
            else
                Console.WriteLine("Invalid");
        }

        public void CheckGradeWithSwitch()
        {
            char grade;
            Console.WriteLine("Enter the grade :");
            grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'O':
                    Console.WriteLine("Outstanding");
                    break;
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("VeryGood");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Poor");
                    break;
                default:
                    Console.WriteLine("Invalid Data");
                    break;
            }
        }
    }

    class Loops
    {
        public void ForLoop()
        {
            int total = 0;
            for(int i=1;i<=5;i++)
            {
                if (i == 3)
                    // break;
                    continue;
                Console.WriteLine("For Loop Values {0}",i);
                total += i;
            }
            Console.WriteLine("The sum of the loop numbers is {0}", total);
        }

        public void WhileLoop()
        {
            int i = 1;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void DoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
    }
}
