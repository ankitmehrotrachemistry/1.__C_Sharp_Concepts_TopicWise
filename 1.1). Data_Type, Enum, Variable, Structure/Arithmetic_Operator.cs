using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int output;
            int x = 4, y = 2;
            output = (x + y);
            Console.WriteLine("Addition Operator : " +output);
            output = (x - y);
            Console.WriteLine("Subtraction Operator : " + output);
            output = (x * y);
            Console.WriteLine("Multiplication Operator : " + output);
            output = (x / y);
            Console.WriteLine("Division Operator : " + output);
            output = (x % y);
            Console.WriteLine("Modulus Operator : " + output);
        }
    }
}
