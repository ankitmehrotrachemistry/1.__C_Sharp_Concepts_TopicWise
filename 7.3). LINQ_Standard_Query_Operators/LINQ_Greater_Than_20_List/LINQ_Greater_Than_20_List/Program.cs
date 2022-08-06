using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Greater_Than_20_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(90);
            list.Add(50);
            list.Add(70);

            Console.WriteLine("Members of List are :");

            foreach (var listNum in list)
            {
                Console.Write(listNum + " ");
            }

            List<int> FilterList = list.FindAll(x => x > 20 ? true : false);

            Console.WriteLine("\n\nNumbers greater than 20 are : ");

            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
