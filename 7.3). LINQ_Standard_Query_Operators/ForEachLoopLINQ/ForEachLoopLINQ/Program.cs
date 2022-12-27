using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoopLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "aa", "ab", "baa", "cb", "gfsdhg", "gtey", "a" };
            IEnumerable<string> enumerable()
            {
                return from string name in nameList
                       where name.Length < 3
                       select name;
            }
            string s = "";
            Console.Write("String whose length is less than 3 are : ");
            foreach(string str in enumerable())
            {
                s += str + " ";
            }
            Console.Write(s);
            Console.WriteLine();
        }
    }
}