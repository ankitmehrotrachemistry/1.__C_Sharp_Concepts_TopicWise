using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 8;
            string str1 = "Ankit", str2 = "Mehrotra";

            Console.WriteLine("Sum is : " + KeyFunction.Add(a, b));
            Console.WriteLine("Bitwise AND is : " + KeyFunction.AndOperator(a,b));
            Console.WriteLine("Ternary Operator is : " + KeyFunction.TernaryOperator(a,b));
            Console.WriteLine("Concatenation of 2 String is : " +KeyFunction.JoinString(str1,str2));
        }
    }
}
