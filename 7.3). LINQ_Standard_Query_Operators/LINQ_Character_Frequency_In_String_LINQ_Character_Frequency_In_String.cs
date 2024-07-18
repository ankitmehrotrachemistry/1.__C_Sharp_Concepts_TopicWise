using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Character_Frequency_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            Console.WriteLine("Input the String : ");
            str = Console.ReadLine();

            var frequency = from x in str
                            group x by x into y
                            select y;

            Console.Write("The Frequency of Characters are : \n");

            foreach (var arr in frequency)
            {
                Console.WriteLine("Character " + arr.Key + ": " + arr.Count() + " times");
            }
        }
    }
}
