using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_Demo
{
    class Program1
    {
        public static void Show()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Namespace_Demo.Program1.Show();
    }
}
