using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://stackoverflow.com/questions/32257510/why-does-this-program-write-a-blank-line-instead-of-a-string-value

namespace Aristo_Async_Task
{
    class Program
    {
        private static string results;
        static void Main(string[] args)
        {
            //CallSaySomething();
            SaySomething();
            Console.WriteLine(results);
        }
        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            results = "Hello World";
            return "Something";
        }

        /*
        static string CallSaySomething()
        {
            var task = SaySomething();
            task.Wait();

            var result = task.Result;
            return result;
        }
        */
    }
}
