using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int factorial = 1;
            Console.Write("Enter the number : ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Factorial of " + n + " is: " + factorial);
        }
    }
}