using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_LambdaExpression
{
    class Program
    {
        public delegate int Calculate(int a, int b);
        public static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Calculate _calculate = new Calculate(Add);
            Console.WriteLine("Sum of numbers using Delegate : " + _calculate(2,4));


            Calculate _calculate1 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine("Sum of numbers using Anonymous Method : " + _calculate1(20,40));


            Calculate _calculate2 = (a, b) => a + b;
            Console.WriteLine("Sum of Numbers using Lambda Expressions : " + _calculate2(50, 100));
        }
    }
}
