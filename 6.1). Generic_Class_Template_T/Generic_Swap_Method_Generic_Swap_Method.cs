using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Swap_Method
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 40, b = 80;
            Console.WriteLine("Before Int Swap : {0} {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After Int Swap : {0} {1}", a, b);

            string str1 = "Ankit", str2 = "Mehrotra";
            Console.WriteLine("Before String Swap : {0} {1}", str1, str2);
            Swap<string>(ref str1, ref str2);
            Console.WriteLine("After String Swap : {0} {1}", str1, str2);
        }
    }
}
