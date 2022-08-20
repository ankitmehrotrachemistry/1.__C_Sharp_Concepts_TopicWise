using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_CompareTo
{
    class Program
    {
        enum Color 
        {
            RED = 0,
            GREEN = 1,
            YELLOW = 2,
            WHITE = 3,
            BLACK = 4
        };

        static void Main(string[] args)
        {
            Color firstColor = Color.RED;
            Color secondColor = Color.WHITE;
            Color thirdColor = Color.BLACK;
            Color fourthColor = Color.GREEN;

            if (firstColor.CompareTo(secondColor) > 0)
                Console.WriteLine("First Color greater than Second Color");
            else
                Console.WriteLine("First Color lesser than Second Color");


            if (secondColor.CompareTo(thirdColor) > 0)
                Console.WriteLine("Second Color greater than Three Color");
            else
                Console.WriteLine("Second Color lesser than Three Color");


            if(thirdColor.CompareTo(fourthColor) > 0)
                Console.WriteLine("Third Color greater than Fourth Color");
            else
                Console.WriteLine("Third Color lesser than Fourth Color");
        }
    }
}
