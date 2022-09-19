using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method_Any
{
    class Program
    {
        public static void CustomPrint<T>(T value)
        {
            Console.WriteLine("Input is : " +value);
        }
        static void Main(string[] args)
        {
            CustomPrint(100);
            CustomPrint("Hello Ankit");
            CustomPrint(12.54f);
            CustomPrint('C');
        }
    }
}
