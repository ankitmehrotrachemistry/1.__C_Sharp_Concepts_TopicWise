using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Check_GreaterThan5
{
    class Program
    {
        delegate bool Check(int number);
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        bool IsGreaterThan5(int number)
        {
            return number > 5;
        }
        void Run()
        {
            Check iseven = IsEven;

            iseven += IsGreaterThan5;
            Console.WriteLine(iseven(4));

            Console.WriteLine(iseven.Target == this);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }
    }
}
