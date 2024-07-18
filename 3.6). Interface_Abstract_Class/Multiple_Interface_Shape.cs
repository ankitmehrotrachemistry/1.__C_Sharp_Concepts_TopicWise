using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interface_Shape
{
    public interface IShape
    {
        double Area();
    }
    public interface IShapeDisplay
    {
        void Display();
    }
    public class Circle : IShape, IShapeDisplay
    {
        public int radius;
        public double Area()
        {
            return ((double)(3.14*radius * radius));
        }
        public double Circumference()
        {
            return ((double)(2*3.14* radius));
        }
        public void Display()
        {
            Console.WriteLine("\nDisplay Circle");
            Console.WriteLine("Radius of Circle is : {0}", this.radius);
            Console.WriteLine("Area of Circle is : {0}", this.Area());
            Console.WriteLine("Circumeference is : {0}", this.Circumference());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.radius = 4;
            cir.Display();
        }
    }
}