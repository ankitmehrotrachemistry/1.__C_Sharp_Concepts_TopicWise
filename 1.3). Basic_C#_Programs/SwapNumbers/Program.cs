using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 8;

            Console.WriteLine("Before Swap a is " +a+ " and b is " +b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After swap a is " +a+ " and b is " +b);

        }
    }
}
