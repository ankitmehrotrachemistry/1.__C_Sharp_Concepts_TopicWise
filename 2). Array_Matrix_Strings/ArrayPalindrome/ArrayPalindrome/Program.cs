using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPalindrome
{
    class ArrayPalindromeProgram
    {
        static int palindrome(int[] arr,
                              int begin, int end)
        {
            // base case 
            if (begin >= end)
            {
                return 1;
            }
            if (arr[begin] == arr[end])
            {
                return palindrome(arr, begin + 1,
                                       end - 1);
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int[] a = { 3, 6, 0, 6, 3 };
            int n = a.Length;

            if (palindrome(a, 0, n - 1) == 1)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}