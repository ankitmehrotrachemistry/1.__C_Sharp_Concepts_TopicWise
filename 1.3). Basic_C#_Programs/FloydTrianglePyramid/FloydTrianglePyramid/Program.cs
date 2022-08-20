using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloydTrianglePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Floyd's Triangle");

            int row;
            int space = 0, a = 1;

            row = Convert.ToInt32(Console.ReadLine());

            space = row + 4 - 1;
            for(int i = 0; i <= row; i++)
            {
                for (int j = space; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("{0} ",a);
                    a++;
                }
                space--;
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
