using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    class Program
    {
        public delegate void NewDelegate();
        static void Display1()
        {
            Console.WriteLine("Ankit");
        }
        static void Display2()
        {
            Console.WriteLine("Mehrotra");
        }
        static void Main(string[] args)
        {
            NewDelegate del = Display1;
            del = del + Display2;

            del();

            del = del - Display2;

            del();
        }
    }
}