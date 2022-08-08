using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int count = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", n);
            }
        }
    }
}