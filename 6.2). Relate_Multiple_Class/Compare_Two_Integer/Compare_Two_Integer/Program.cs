using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Two_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = Convert.ToInt32(Console.ReadLine());

            if (a > KeyManager.MAXIMUM)
            {
                Console.WriteLine("Value is greater");
            }
            /*else if (KeyManager.MINIMUM < a < KeyManager.MAXIMUM)
            {
                Console.WriteLine("Value is between");
            }
            else if (a < KeyManager.MINIMUM)
            {
                Console.WriteLine("Value is lesser");
            }*/
            else
            {
                Console.WriteLine("Value is less");
            }
        }
    }
}
