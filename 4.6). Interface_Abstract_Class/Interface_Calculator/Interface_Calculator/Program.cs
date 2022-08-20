using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(2,6));
        }
    }
}
