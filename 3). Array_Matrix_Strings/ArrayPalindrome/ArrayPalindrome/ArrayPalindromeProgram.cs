// c# Program to find Palindrome Array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPalindrome
{
    class ArrayPalindromeProgram
    {
        static int palindromeArray(int[] arr, int begin, int end)
        {
            if (begin >= end)
            {
                return 1;
            }
            if (arr[begin] == arr[end])
            {
                return palindromeArray(arr, begin + 1, end - 1);
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int[] testArray = { 3, 6, 0, 6, 3 };
            int n = testArray.Length;

            if (palindromeArray(testArray, 0, n - 1) == 1)
                Console.WriteLine("The Array is a Palindrome");
            else
                Console.WriteLine("The Array is not a Palindrome");
        }
    }
}