using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{
    interface IPolygon
    {
        void calculateArea(int a, int b);
    }

    interface IColor
    {
        void getColor();
    }

    class Rectangle : IPolygon, IColor
    {
        public void calculateArea(int a, int b)
        {

            int area = a * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
        public void getColor()
        {

            Console.WriteLine("Red Rectangle");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();

            r1.calculateArea(100, 200);
            r1.getColor();
        }
    }
}
