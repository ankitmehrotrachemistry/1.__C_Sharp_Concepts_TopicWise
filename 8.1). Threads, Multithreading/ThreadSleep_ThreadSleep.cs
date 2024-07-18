using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSleep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method");

            var t = new Thread(new ThreadStart(DoWork));

            t.Start();
            // Add Thread.Sleep(1000) here and see the result!!
            Console.WriteLine("End of Main Method!");
        }

        private static void DoWork()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Thread doing Work");
        }
    }
}
