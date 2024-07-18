using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Integral
{
    class Program
    {
        static void Main(string[] args)
        {
            // sbyte

            sbyte a = -10;
            Console.WriteLine("Sbyte");
            Console.WriteLine("a = " +a);
            Console.WriteLine("Type of Variable = " +a.GetType());
            Console.WriteLine("Size of sbyte = " +sizeof(sbyte));
            Console.WriteLine("Min size of sbyte = " +sbyte.MinValue);
            Console.WriteLine("Max size of sbyte = " +sbyte.MaxValue);
            Console.WriteLine();

            // byte

            byte b = 10;
            Console.WriteLine("Byte");
            Console.WriteLine("b = " + b);
            Console.WriteLine("Type of Variable = " + b.GetType());
            Console.WriteLine("Size of byte = " + sizeof(byte));
            Console.WriteLine("Min size of byte = " + byte.MinValue);
            Console.WriteLine("Max size of byte = " + byte.MaxValue);
            Console.WriteLine();

            // char

            char c = 'A';
            Console.WriteLine("Char ..");
            Console.WriteLine("c = " + c);
            Console.WriteLine("Type of Variable = " + c.GetType());
            Console.WriteLine("Size of char = " + sizeof(char));
            Console.WriteLine("Min size of char = " + (int)(char.MinValue));
            Console.WriteLine("Max size of char = " + (int)(char.MaxValue));
            Console.WriteLine();

            // short

            short d = -18910;
            Console.WriteLine("Short ..");
            Console.WriteLine("d = " + d);
            Console.WriteLine("Type of Variable = " + d.GetType());
            Console.WriteLine("Size of short = " + sizeof(short));
            Console.WriteLine("Min size of short = " + short.MinValue);
            Console.WriteLine("Max size of short = " + short.MaxValue);
            Console.WriteLine();

            // ushort

            ushort e = 18910;
            Console.WriteLine("Ushort ..");
            Console.WriteLine("e = " + e);
            Console.WriteLine("Type of Variable = " + e.GetType());
            Console.WriteLine("Size of ushort = " + sizeof(ushort));
            Console.WriteLine("Min size of ushort = " + ushort.MinValue);
            Console.WriteLine("Max size of ushort = " + ushort.MaxValue);
            Console.WriteLine();

            // int

            int f = -894364326;
            Console.WriteLine("Int ..");
            Console.WriteLine("f = " + f);
            Console.WriteLine("Type of Variable = " + f.GetType());
            Console.WriteLine("Size of int = " + sizeof(int));
            Console.WriteLine("Min size of int = " + int.MinValue);
            Console.WriteLine("Max size of int = " + int.MaxValue);
            Console.WriteLine();

            // uint

            uint g = 894364326;
            Console.WriteLine("UInt ..");
            Console.WriteLine("g = " + g);
            Console.WriteLine("Type of Variable = " + g.GetType());
            Console.WriteLine("Size of uint = " + sizeof(uint));
            Console.WriteLine("Min size of uint = " + uint.MinValue);
            Console.WriteLine("Max size of uint = " + uint.MaxValue);
            Console.WriteLine();

            // long

            long h = -9090894364326;
            Console.WriteLine("Long ..");
            Console.WriteLine("h = " + h);
            Console.WriteLine("Type of Variable = " + h.GetType());
            Console.WriteLine("Size of long = " + sizeof(long));
            Console.WriteLine("Min size of long = " + long.MinValue);
            Console.WriteLine("Max size of long = " + long.MaxValue);
            Console.WriteLine();

            // ulong

            ulong i = 9090894364326;
            Console.WriteLine("ulong ..");
            Console.WriteLine("i = " + i);
            Console.WriteLine("Type of Variable = " + i.GetType());
            Console.WriteLine("Size of ulong = " + sizeof(ulong));
            Console.WriteLine("Min size of ulong = " + ulong.MinValue);
            Console.WriteLine("Max size of ulong = " + ulong.MaxValue);
            Console.WriteLine();
        }
    }
}
