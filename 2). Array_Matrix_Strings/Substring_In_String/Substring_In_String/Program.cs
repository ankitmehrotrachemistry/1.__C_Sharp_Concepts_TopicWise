using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            bool present;
            int T;
            T = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the String : ");
            str1 = Console.ReadLine();

            while (T-- > 0)
            {
                Console.Write("\nInput the Substring to search : ");
                str2 = Console.ReadLine();

                present = str1.Contains(str2);

                if (present)
                    Console.WriteLine("The Substring is present in String\n");
                else
                    Console.WriteLine("The Substring is not present in String\n");
            }
            
        }
    }
}
