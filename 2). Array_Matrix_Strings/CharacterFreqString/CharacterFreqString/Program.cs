using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterFreqString
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            string str;

            int i, freq = 0, flag = 0;

            Console.WriteLine("Enter the String or Sentence");
            str = Console.ReadLine();

            Console.WriteLine("Enter character to search");
            ch = char.Parse(Console.ReadLine());

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    flag = 1;
                    Console.WriteLine(ch+ " occurs at position " +i);
                    freq++;
                }
            }
            if (flag == 1)
                Console.WriteLine("Character " + " ' " + ch + " ' " + " occured " + freq + " times");
            else
                Console.WriteLine("Character not found");
        }
    }
}
