using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P = new Person();
            P.Name = "Ankit";

            Console.WriteLine(P.Name);
        }
    }
}

