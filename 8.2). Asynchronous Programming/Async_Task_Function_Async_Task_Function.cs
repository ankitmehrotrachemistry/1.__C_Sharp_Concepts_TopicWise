using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Task_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName();
            PrintSum(10,40);
            Console.WriteLine("Last Function");
            Console.ReadLine();
        }
        static void PrintName()
        {
            Console.WriteLine("Ankit Mehrotra");
        }
        static async Task PrintSum(int a, int b)
        {
            await Task.Delay(2000);
            await Task.Run(() => Console.WriteLine("Sum is :" +(a+b)));
        }
    }
}
