using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Anonymous_Method
{
    class Program
    {
        public delegate string WelcomeDelegate(string name);
        public static string Welcome(string name)
        {
            return "Hello " + name + " Welcome to C# Tutorial";
        }
        static void Main(string[] args)
        {
            WelcomeDelegate wd = new WelcomeDelegate(Program.Welcome);

            string WelcomeMessage = wd.Invoke("Ankit");

            Console.WriteLine(WelcomeMessage);
        }
    }
}