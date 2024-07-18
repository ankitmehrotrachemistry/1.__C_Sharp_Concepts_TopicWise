using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CartesianProduct_SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            var List1 = new string[] {"A", "B", "C", "D"};
            var List2 = new String[] {"1", "2", "3", "4"};

            var CartesianList = List1.SelectMany(x => List2.Select(y => x + y + ' '));

            foreach (var list in CartesianList)
            {
                Console.Write(list);
            }
        }
    }
}
