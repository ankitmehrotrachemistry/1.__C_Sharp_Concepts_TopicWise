using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Class_3_Different_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            var My_Tuple = Tuple.Create("Ankit", 224, 'A');

            Console.WriteLine("Element 1 : " + My_Tuple.Item1);
            Console.WriteLine("Element 2 : " + My_Tuple.Item2);
            Console.WriteLine("Element 3 : " + My_Tuple.Item3);
        }
    }
}
