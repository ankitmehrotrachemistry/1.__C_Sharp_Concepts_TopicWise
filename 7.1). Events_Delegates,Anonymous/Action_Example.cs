using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Example
{
    class Program
    {
        public static void DoSomething()
        {
            Console.WriteLine("Do Some Action Demo");
        }
        static void Main(string[] args)
        {
            Action doAction = new Action(DoSomething);

            doAction();
        }
    }
}
