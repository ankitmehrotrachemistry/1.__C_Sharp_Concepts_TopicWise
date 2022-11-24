using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dynInteger = 10;
            Console.WriteLine("Value of Int : {0}, Type : {1} ", dynInteger, dynInteger.GetType());
            dynamic dynString = "Hello Ankit";
            Console.WriteLine("Value of String : {0}, Type : {1} ", dynString, dynString.GetType());
            dynString = "Hello World";
            Console.WriteLine("Value of String : {0}, Type : {1} ", dynString, dynString.GetType());
        }
    }
}
