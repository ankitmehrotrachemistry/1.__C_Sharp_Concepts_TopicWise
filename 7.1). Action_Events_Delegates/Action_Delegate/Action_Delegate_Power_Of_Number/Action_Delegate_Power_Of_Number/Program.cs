using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_Power_Of_Number
{
    class Program
    {
        public static void Power(double num1, double num2)
        {
            Console.WriteLine("Power of number is {0}", Math.Pow(num1, num2));
        }
        static void Main(string[] args)
        {
            Action<double, double> doublevalue = Power;
            doublevalue(2,4);
        }
    }
}
