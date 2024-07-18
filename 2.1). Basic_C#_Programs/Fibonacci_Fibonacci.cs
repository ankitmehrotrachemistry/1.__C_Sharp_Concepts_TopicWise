using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            int i , n ;

            n = int.Parse(Console.ReadLine());

            Console.Write(a + " " + b + " ");

            for (i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
