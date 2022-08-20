using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesMulticasting
{
    class Program
    {
        public delegate void RectDelegate(double height, double width);

        public void Area(double height, double width)
        {
            Console.WriteLine("Area is {0}", (width * height));
        }
        public void Perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is {0}", 2 * (width + height));
        }
        static void Main(string[] args)
        {
            Program P = new Program();

            RectDelegate rectDel = new RectDelegate(P.Area);

            rectDel += P.Perimeter;

            rectDel.Invoke(5.4, 2.4);
            Console.WriteLine();

            rectDel.Invoke(2.4, 1.2);
        }
    }
}
