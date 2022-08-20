using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Sort_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sortList = new List<int>();

            sortList.Add(25);
            sortList.Add(15);
            sortList.Add(5);
            sortList.Add(10);
            sortList.Add(20);

            Console.WriteLine("Initial List");
            foreach (int value in sortList)
            {
                Console.WriteLine(value);
            }

            sortList.Sort();

            Console.WriteLine("List after Sorting is : ");
            foreach (int value in sortList)
            {
                Console.WriteLine(value);
            }

            sortList.Reverse();
            Console.WriteLine("List after Reversal is : ");
            foreach (int value in sortList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
