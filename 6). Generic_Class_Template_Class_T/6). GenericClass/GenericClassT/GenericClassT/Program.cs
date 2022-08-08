using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassT
{
    class Program
    {
        static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            char c, d;

            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            Console.WriteLine("Integer Before Swap");
            Console.WriteLine("a = {0},  b = {1}", a, b);
            Console.WriteLine("Char Before Swap");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            Console.WriteLine("Integer after Swap");
            Console.WriteLine("a = {0},  b = {1}", a, b);
            Console.WriteLine("Char after Swap");
            Console.WriteLine("c = {0}, d = {1}", c, d);

        }
    }
}
