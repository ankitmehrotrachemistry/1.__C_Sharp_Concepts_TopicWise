using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_Keyword_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 120;
            var y = -10.56;
            var z = "Raju";
            Console.WriteLine("Value of x : {0}, type of x : {1}", x, x.GetType());
            Console.WriteLine("Value of y : {0}, type of y : {1}", y, y.GetType());
            Console.WriteLine("Value of z : {0}, type of z : {1}", z, z.GetType());
        }
    }
}