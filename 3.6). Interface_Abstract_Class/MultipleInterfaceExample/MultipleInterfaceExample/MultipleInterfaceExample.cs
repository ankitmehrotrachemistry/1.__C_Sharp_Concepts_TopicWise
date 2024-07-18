using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceExample
{
    public interface IShape
    {
        double Area();
        int Sides { get; }
    }

    public interface IShapeDisplay
    {
        void Display();
    }
    public class Square : IShape, IShapeDisplay
    {
        private int InSides;
        public int SideLength;

        public int Sides
        {
            get { return InSides; }
        }
        public double Area()
        {
            return ((double) (SideLength * SideLength));
        }
        public double Circumference()
        {
            return ((double)(Sides * SideLength));
        }
        public Square()
        {
            InSides = 4;
        }

        public void Display()
        {
            Console.WriteLine("Displaying Square information:");
            Console.WriteLine("Side length: {0}", this.SideLength);
            Console.WriteLine("Sides: {0}", this.Sides);
            Console.WriteLine("Area: {0}", this.Area());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new Square();
            mySquare.SideLength = 7;

            mySquare.Display();
        }
    }
}
