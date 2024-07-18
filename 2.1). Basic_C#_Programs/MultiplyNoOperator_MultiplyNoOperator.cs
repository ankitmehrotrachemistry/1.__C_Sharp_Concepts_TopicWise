using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyNoOperator
{
    class Program
    {
        static int add(int a, int b)
        {
            int c;
            while (b != 0)
            {
                c = (a & b) << 1;
                a = a ^ b;
                b = c;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int n1, n2, mul = 0, i;

            Console.WriteLine("Enter first number");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            n2 = int.Parse(Console.ReadLine());

            for (i = 0; i < n2; i++)
            {
                mul = add(mul, n1);
            }
            Console.WriteLine("Multiplication is " +mul);
        }
    }
}
