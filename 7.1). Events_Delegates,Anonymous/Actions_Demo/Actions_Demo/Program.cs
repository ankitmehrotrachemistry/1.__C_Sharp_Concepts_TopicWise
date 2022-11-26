using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action a = () => Console.Write("Method A\n");
            Action b = () => Console.Write("Method B");
            Action ab = a + b;
            ab();
            Console.WriteLine();
        }
    }
}
