using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_String_Concat
{
    class Program
    {
        public static void Join(string str)
        {
            Console.WriteLine("Welcome to {0}", str);
        }
        static void Main(string[] args)
        {
            Action<string> stringValue = Join;
            stringValue("C#");
        }
    }
}
