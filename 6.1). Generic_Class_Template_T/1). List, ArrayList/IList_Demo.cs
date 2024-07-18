using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IList_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> marks = new List<int>();

            marks.Add(10);
            marks.Add(20);
            marks.Add(30);
            marks.Add(40);

            Console.Write("IList Elements are :");
            foreach (var a in marks)
                Console.Write(a + " ");
            marks.RemoveAt(2);

            Console.Write("\n");
            Console.Write("IList after removal are : ");
            foreach (var m in marks)
                Console.Write(m + " ");

            Console.Write("\n");
        }
    }
}
