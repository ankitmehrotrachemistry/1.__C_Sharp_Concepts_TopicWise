using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > 0)
            {
                Console.WriteLine("Entered number is Positive!");
            }
            else
            {
                Console.WriteLine("Entered number is Negative!");
            }
        }
    }
}