using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", rev = "";
            int length = 0;

            str = Console.ReadLine();

            length = str.Length - 1;

            while (length >= 0)
            {
                rev = rev + str[length];
                length--;
            }

            Console.WriteLine("Reversed Word is {0}", rev);
        }
    }
}
