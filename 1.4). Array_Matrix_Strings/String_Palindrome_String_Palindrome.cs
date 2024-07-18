using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "", rev = "";
            int length = 0;
            str = Console.ReadLine();
            length = str.Length -1;
            while (length >= 0)
            {
                rev = rev + str[length];
                length--;
            }
            Console.WriteLine("Reversed Word is {0}", rev);
            //Check Palindrome Condition of String
            if (str == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Non-Palindrome");
            }
        }
    }
}