using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Function
{
    class KeyFunction
    {
        public static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public static int AndOperator(int a, int b)
        {
            int c = a & b;
            return c;
        }

        public static int TernaryOperator(int a, int b)
        {
            int c;
            c = a > b ? a : b;
            return c;
        }

        public static string JoinString(string str1, string str2)
        {
            string str;
            str = str1 + " " + str2;
            return str;
        }
    }
}
