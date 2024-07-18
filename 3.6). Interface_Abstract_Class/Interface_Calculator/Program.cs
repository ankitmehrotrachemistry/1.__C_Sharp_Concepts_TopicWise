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
            Console.WriteLine("Addition of Numbers : " + calculator.Add(2,6));
            Console.WriteLine("Multiplication of Numbers : " + calculator.Multiply(4, 8));
        }
    }
}
