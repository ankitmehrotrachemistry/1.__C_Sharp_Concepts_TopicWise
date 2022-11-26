using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Palindrome_Function
{
    class Program
    {
        static bool checkPalindrome(int n)
        {
            int reverse = 0;
            int temp = n;

            while (temp != 0) {
                reverse = (reverse * 10) + (temp % 10);
                temp = temp / 10;
            }
            return (reverse == n);    
        }
        static void Main(string[] args)
        {
            int num = 1234321;

            if (checkPalindrome(num) == true)
            {
                Console.WriteLine("Yes, It is Palindrome!!");
            }
            else
            {
                Console.WriteLine("Not a Palindrome!!");
            }
        }
    }
}