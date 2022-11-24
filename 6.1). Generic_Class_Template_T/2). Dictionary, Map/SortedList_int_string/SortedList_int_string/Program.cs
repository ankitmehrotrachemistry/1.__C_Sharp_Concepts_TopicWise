using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_int_string
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedListDemo = new SortedList<int, string>();

            sortedListDemo.Add(4, "Four");
            sortedListDemo.Add(1, "One");
            sortedListDemo.Add(0, "Zero");
            sortedListDemo.Add(8, "Eight");
            sortedListDemo.Add(10, "Ten");

            Console.WriteLine("SortedList values are : ");
            foreach (var kvp in sortedListDemo)
                Console.WriteLine("Key : {0}, Value : {1}", kvp.Key, kvp.Value);
        }
    }
}
