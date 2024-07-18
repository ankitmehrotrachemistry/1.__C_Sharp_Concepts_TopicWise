using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_AsParameter
{
    class Program
    {
        public delegate void Print(int value);
        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number : {0, -12:NO}", num);
        }
        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money : {0:C}", money);
        }
        static void Main(string[] args)
        {
            PrintHelper(PrintNumber, 10000);
            PrintHelper(PrintMoney, 10000);
        }
    }
}