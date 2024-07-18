using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- MY CALCULATOR ---------");
            Console.WriteLine("1 to Add");
            Console.WriteLine("2 to Subtract");
            Console.WriteLine("3 to Multiply");
            Console.WriteLine("4 to Divide");
            Console.WriteLine("Enter your choice");
            int num = Int32.Parse(Console.ReadLine());
            int x, y, z;
            switch(num)
            {
                case 1:
                    Console.WriteLine("Enter x");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x + y;
                    Console.WriteLine("Sum = {0}", z);
                    break;
                case 2:
                    Console.WriteLine("Enter x");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x - y;
                    Console.WriteLine("Difference = {0}", z);
                    break;
                case 3:
                    Console.WriteLine("Enter x");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x * y;
                    Console.WriteLine("Product = {0}", z);
                    break;
                case 4:
                    Console.WriteLine("Enter x");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter y");
                    y = Convert.ToInt32(Console.ReadLine());
                    z = x / y;
                    Console.WriteLine("Division = {0}", z);
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
