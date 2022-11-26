using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate
{
    class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Action<int> printActionDelegate = ConsolePrint;
            printActionDelegate(100);
        }
    }
}
