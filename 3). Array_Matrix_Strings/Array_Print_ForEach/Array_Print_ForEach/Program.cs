using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Print_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = {'A','n','k','i','t'};
            foreach(char ch in charArray)
            {
                Console.WriteLine(ch);
            }
        }
    }
}