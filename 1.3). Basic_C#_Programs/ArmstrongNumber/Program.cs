using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            int rem;

            num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum = sum + rem * rem * rem;
            }

            if (sum == num)
            {
                Console.Write("{0} is an Armstrong Number", num);
            }
            else
            {
                Console.Write("{0} is not an Armstrong Number", num);
            }
        }
    }
}