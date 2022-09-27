using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameter_Example
{
    class Program
    {
        public static void Addition(out int i)
        {
            i = 20;
            i *= i;
        }
        static void Main(string[] args)
        {
            int i;

            Addition(out i);

            Console.WriteLine("Addition of Value is : {0}", i);
        }
    }
}
