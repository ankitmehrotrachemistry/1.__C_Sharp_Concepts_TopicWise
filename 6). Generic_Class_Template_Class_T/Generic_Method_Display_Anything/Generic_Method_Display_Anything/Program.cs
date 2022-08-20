using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Method_Display_Anything
{
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            printer.Print("Ankit");
            printer.Print(100);
            printer.Print('C');
            printer.Print(true);
        }
    }
}
