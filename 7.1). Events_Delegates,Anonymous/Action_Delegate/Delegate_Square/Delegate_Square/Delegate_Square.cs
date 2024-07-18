using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Square
{
    class Program
    {
        public delegate int Square(int num);
        static int SquareNumber(int num)
        {
            return(Convert.ToInt32(num*num));
        }
        static void Main(string[] args)
        {
            Square sq = SquareNumber;

            Console.WriteLine("Area of Square is : " +sq(5).ToString());
        }
    }
}
