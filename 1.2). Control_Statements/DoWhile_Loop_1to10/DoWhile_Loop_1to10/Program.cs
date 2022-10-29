using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile_Loop_1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;
            } while (i <= 10);
        }
    }
}
