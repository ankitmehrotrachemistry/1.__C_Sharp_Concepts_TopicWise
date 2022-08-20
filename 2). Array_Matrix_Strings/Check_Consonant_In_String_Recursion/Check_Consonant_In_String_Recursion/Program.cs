using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Consonant_In_String_Recursion
{
    class Program
    {
        static Boolean isConsonant(char ch)
        {
            ch = char.ToUpper(ch);

            return (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'E' || ch == 'U') == false && ch >= 65 && ch <= 90; 
        }
        static int totalConsonants(String str, int n)
        {
            if (n == 1)
            {
                if (isConsonant(str[0]))
                    return 1;
                else
                    return 0;
            }
            if (isConsonant(str[n - 1]))
                return totalConsonants(str, n - 1) + 1;
            else
                return totalConsonants(str, n - 1);
        }
        static void Main(string[] args)
        {
            string str = "Ankit Mehrotra";
            Console.WriteLine("Total number of Consonants are : " +totalConsonants(str, str.Length));
        }
    }
}
