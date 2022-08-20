using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputDelegate
{
    delegate string del(string str);
    class sample
    {
        public static string DelegateSample(string a)
        {
            return a.Replace(',','*');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            del str1 = new del(sample.DelegateSample);

            string str = str1("Welcome, friends, to, Technology");
            Console.WriteLine(str);
        }
    }
}
