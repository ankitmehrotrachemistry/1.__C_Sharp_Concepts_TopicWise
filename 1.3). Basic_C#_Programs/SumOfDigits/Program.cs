using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum=0, rem;
            Console.Write("Enter the value of n : ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits is " + sum);
        }
    }
}
