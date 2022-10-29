using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Statement_Eligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            NonEligible:
            Console.WriteLine("You are ineligible to give UPSC Exam");
            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 21)
            {
                goto NonEligible;
            }
            else
            {
                Console.WriteLine("You are eligible to give UPSC Exam");
            }
        }
    }
}
