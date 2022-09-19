using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_LockKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Main Thread");

            var t1 = new Thread(new ThreadStart(AddToList));
            t1.Start();

            var t2 = new Thread(new ThreadStart(AddToList));
            t2.Start();

            var t3 = new Thread(new ThreadStart(AddToList));
            //t3.Start();

            Console.WriteLine("Main Method End");
        }
        private static object myLock = new object();
        private static List<int> numbers = new List<int>();
        private static Random rnd = new Random();
        private static int total = 0;

        private static void AddToList()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(rnd.Next(1,500));
                // Multiple Threads can run at same time, Thread Safety so that there is no conflict.
                lock (myLock)
                {
                    numbers.Add(i);
                }

                 
            }
        }
    }
}
