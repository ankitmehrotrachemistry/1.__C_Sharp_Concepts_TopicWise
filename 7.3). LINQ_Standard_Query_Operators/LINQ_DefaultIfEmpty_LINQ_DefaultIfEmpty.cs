using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_DefaultIfEmpty
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> playerList = new List<string>();

            var list1 = playerList.DefaultIfEmpty();
            var list2 = playerList.DefaultIfEmpty("None");

            Console.WriteLine("Count {0}", list1.Count());
            Console.WriteLine("Value {0}", list1.ElementAt(0));

            Console.WriteLine("Count {0}", list2.Count());
            Console.WriteLine("Value {0}", list2.ElementAt(0));
        }
    }
}
