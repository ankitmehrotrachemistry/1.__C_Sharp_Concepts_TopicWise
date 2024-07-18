using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        public delegate int Multiply(int num1, int num2);
        static void Main(string[] args)
        {
            Func<int, int> square = (i => i * i); // Using Lambda Expressions

            Console.WriteLine("Square of number using Lambda Expression is : " +square(5).ToString());


            Multiply mul = delegate (int n1, int n2) // Using Delegates
            {
                return n1 * n2;
            };
            Console.WriteLine("Multiplication of 2 numbers are : " +mul(5,2).ToString());
        }
    }
}
