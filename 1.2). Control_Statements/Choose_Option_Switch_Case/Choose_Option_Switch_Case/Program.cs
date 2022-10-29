using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Option_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start\n2. Resume\n3. High Score \n4.Exit\nEnter your choice : ");
            int c = Convert.ToInt32(Console.ReadLine());
            switch(c)
            {
                case 1: Console.WriteLine("\nStart"); break;
                case 2: Console.WriteLine("\nResume"); break;
                case 3: Console.WriteLine("\nHigh Score"); break;
                case 4: Console.WriteLine("\nExit"); break;
                default: Console.WriteLine("\nNot Found"); break;
            }
            Console.ReadKey();
        }
    }
}
