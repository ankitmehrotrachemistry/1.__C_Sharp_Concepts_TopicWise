using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rem;
            int reverse = 0;

            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.Write("Reversed Number is : " + reverse);
        }
    }
}
