using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Occurence_Character_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            string str;
            int freq = 0, flag = 0;
            Console.WriteLine("Enter any String ");
            str = Console.ReadLine();

            Console.WriteLine("Enter Character to search");

            ch = char.Parse(Console.ReadLine());

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    flag = 1;
                    Console.WriteLine("At Positon " + i);
                    freq++;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("Character is : " + ch + " occured " + freq + " times");
            }
            else
            {
                Console.WriteLine("Character not Found");
            }
        }
    }
}
