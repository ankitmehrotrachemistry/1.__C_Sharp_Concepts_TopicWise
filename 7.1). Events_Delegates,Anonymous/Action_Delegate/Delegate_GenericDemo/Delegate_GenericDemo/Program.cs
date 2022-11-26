using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_GenericDemo
{
    class Program
    {
        delegate void Printer<T>(T data);
        private static LinkedList<int> GenerateData()
        {
            var list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.Remove(3);

            return list;
        }
        private static void Display(LinkedList<int> list, Printer<int> printer)
        {
            foreach (var item in list)
            {
                printer(item);
            }
        }
        static void Main(string[] args)
        {
            LinkedList<int> list = GenerateData();

            Display(list, new Printer<int>(Console.WriteLine));

            Console.ReadLine();
        }
    }
}
