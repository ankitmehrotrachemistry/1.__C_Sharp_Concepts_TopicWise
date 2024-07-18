using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_NoParameter
{
    class Program
    {
        public void Display()
        {
            Console.WriteLine("Non-Parameter Function");
        }
        static void Main(string[] args)
        {
            Program p = new Program(); // Creating Instance
            p.Display();
        }
    }
}
