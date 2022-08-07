using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://docs.microsoft.com/en-us/visualstudio/ide/reference/convert-foreach-linq?view=vs-2022

namespace ForEachLoopLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>() { "aa", "ab", "baa", "cb" };

            IEnumerable<string> enumerable()
            {
                return from string name in nameList
                       where name.Length < 3
                       select name;
            }
        }
    }
}
