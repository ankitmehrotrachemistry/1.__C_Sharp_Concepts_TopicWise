using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Keyword
{
    class Program
    {
        public const int myInt = 10;
        public const string myStr = "Ankit";
        static void Main(string[] args)
        {
            Console.WriteLine("Value of myInt : {0} ", myInt);
            Console.WriteLine("Value of myString : {0} ", myStr);
        }
    }
}
