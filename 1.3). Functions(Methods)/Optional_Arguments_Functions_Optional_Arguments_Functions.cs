using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Arguments_Functions
{
    class Program
    {
        static void Add(int a= 12, int b= 10) // Make all parameters Optional
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            Add(2,4);
            Add(8);
            Add();
        }
    }
}
