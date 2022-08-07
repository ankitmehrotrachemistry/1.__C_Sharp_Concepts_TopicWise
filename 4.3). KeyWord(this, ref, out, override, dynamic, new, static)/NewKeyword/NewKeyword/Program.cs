using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKeyword
{
    public class BaseClass
    {
        public static int x = 55;
        public static int y = 22;
    }
    class Program : BaseClass
    {
        new public static int x = 100;
        static void Main(string[] args)
        {
            Console.WriteLine(x);
            Console.WriteLine(BaseClass.x);
            Console.WriteLine(y);
        }
    }
}
