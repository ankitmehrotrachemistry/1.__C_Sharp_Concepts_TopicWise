using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValue_Increment
{
    class Program
    {
        static void Increment(int i)
        {
            i = i + 2;
        }
        static void Main(string[] args)
        {
            int x = 2;

            Increment(4);

            Console.WriteLine("Value of x is : " +x);
        }
    }
}
