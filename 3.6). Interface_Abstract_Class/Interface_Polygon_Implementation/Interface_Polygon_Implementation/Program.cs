using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polygon_Implementation
{
    interface IPolygon
    {
        void calculateArea();
    }
    class Rectangle : IPolygon
    {
        public void calculateArea()
        {
            int length = 40;
            int breadth = 80;

            int areaOfRectangle = length * breadth;

            Console.WriteLine("Area of Rectangle : " + areaOfRectangle);
        }
    }
    class Square : IPolygon
    {
        public void calculateArea()
        {
            int side = 20;
            int areaOfSquare = side * side;
            Console.WriteLine("Area of Square : " + areaOfSquare);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.calculateArea();

            Square sq = new Square();
            sq.calculateArea();
        }
    }
}
