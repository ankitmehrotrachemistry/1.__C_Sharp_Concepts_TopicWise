using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Class_7_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int, int, int, int, int, int> My_Tuple = new Tuple<int, int, int, int, int, int, int>(12,200,42,4,80,98,54);

            Console.WriteLine("Element 1 : " + My_Tuple.Item1);
            Console.WriteLine("Element 2 : " + My_Tuple.Item2);
            Console.WriteLine("Element 3 : " + My_Tuple.Item3);
            Console.WriteLine("Element 4 : " + My_Tuple.Item4);
            Console.WriteLine("Element 5 : " + My_Tuple.Item5);
            Console.WriteLine("Element 6 : " + My_Tuple.Item6); 
            Console.WriteLine("Element 7 : " + My_Tuple.Item7);
        }
    }
}