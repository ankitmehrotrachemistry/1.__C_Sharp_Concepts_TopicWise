using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputAsyncAwait
{
    class Program
    {
        private static string result;
        static void Main(string[] args)
        {
            SaySomething();
            Console.WriteLine(result);
        }
        static async Task<string> SaySomething()
        {
            await Task.Delay(5);
            result = "Hello World";

            return "Something";
        }
    }
}
