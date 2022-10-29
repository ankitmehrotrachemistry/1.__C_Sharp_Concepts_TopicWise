using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            i += 5;
            Console.WriteLine("Add Assignmnet Operator :" +i);
            i *= 2;
            Console.WriteLine("Multiply Assignmnet Operator :" + i);
            i %= 2;
            Console.WriteLine("Modulo Assignmnet Operator :" + i);
            i &= 2;
            Console.WriteLine("Bitwise AND Operator :" + i);
            i ^= 10;
            Console.WriteLine("Bitwise XOR Operator :" + i);
            i >>= 2;
            Console.WriteLine("Right Shift Operator :" + i);
        }
    }
}
