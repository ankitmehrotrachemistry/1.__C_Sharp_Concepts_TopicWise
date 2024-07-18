using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Dictionary_From_Where_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Numbers;
            Numbers = new Dictionary<int, string>();

            Numbers.Add(0, "Zero");
            Numbers.Add(1, "One");
            Numbers.Add(2, "Two");
            Numbers.Add(3, "Three");
            Numbers.Add(4, "Four");

            var evenNumbers = from num in Numbers
                              where (num.Key % 2) == 0
                              select num.Value;

            foreach(string i in evenNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
