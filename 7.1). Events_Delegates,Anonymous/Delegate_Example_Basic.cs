using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Example_Basic
{
    class Program
    {
        public delegate void Print(int val1, int val2);

        static void ConsolePrint(int i, int j)
        {
            Console.WriteLine(i + " , " +j);
        }
        static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(100, 200);
        }
    }
}
