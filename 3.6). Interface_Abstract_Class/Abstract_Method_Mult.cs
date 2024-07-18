using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method_Mult
{
    abstract class MyAbstractClass
    {
        public int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public abstract int MultiplyTwoNumbers(int num1, int num2);
    }
    class Program : MyAbstractClass
    {
        public override int MultiplyTwoNumbers(int n1, int n2)
        {
            return n1 * n2;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int add = p.AddTwoNumbers(2,8);
            int mult = p.MultiplyTwoNumbers(10,8);
            Console.WriteLine("Addition of number is : " +add + " and Multiplication of number is : " +mult);
        }
    }
}