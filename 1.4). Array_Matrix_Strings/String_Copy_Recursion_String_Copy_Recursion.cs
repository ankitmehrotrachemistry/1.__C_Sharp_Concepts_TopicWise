using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Copy_Recursion
{
    class Program
    {
        // Function to copy one string in to other using recursion
        static void CopyStringToOtherFunction(char[] str1, char[] str2, int index)
        {
            str2[index] = str1[index];

            if (index == str1.Length - 1)
            {
                return;
            }
            CopyStringToOtherFunction(str1, str2, index + 1);
        }
        static void Main(string[] args)
        {
            char[] str1 = "Ankit Mehrotra".ToCharArray();
            char[] str2 = new char[str1.Length];
            int index = 0;
            CopyStringToOtherFunction(str1, str2, index);
            Console.WriteLine(String.Join("", str2));
        }
    }
}
