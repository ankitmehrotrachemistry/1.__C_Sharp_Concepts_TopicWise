using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList_Interface
{
    class Program
    {
        static void Print(IList<string> list)
        {
            foreach (string str in list)
            {
                Console.WriteLine("\t"+str);
            }
        }
        static void Main(string[] args)
        {
            string[] countries = {"India","USA","UK","France"};
            Console.WriteLine("Countries are :");
            Print(countries);

            List<string> students = new List<string>();
            students.Add("Chaaya");
            students.Add("Ankit");
            Console.WriteLine("Students are :");
            Print(students);
        }
    }
}
