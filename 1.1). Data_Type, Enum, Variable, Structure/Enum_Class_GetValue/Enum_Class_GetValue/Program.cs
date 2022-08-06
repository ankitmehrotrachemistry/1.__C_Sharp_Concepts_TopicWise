using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Class_GetValue
{
    class Program
    {
        enum Directions
        {
            EAST = 0,
            WEST = 1,
            NORTH = 2,
            SOUTH = 3
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Value of directions are : ");

            foreach (var val in Enum.GetValues(typeof(Directions)))
            {
                Console.WriteLine("{0,3}  0x{0:X8}  {1}", (int)val, ((Directions)val));
            }
        }
    }
}
