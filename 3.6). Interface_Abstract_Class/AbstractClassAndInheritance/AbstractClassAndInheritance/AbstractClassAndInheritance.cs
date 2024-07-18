using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInheritance
{
    abstract class Shape //this abstract Shape class is our base class to inherit from
    { 
        public abstract int CalculateArea();
        // abstract classes may or may not have abstract  functions/fields, in this case we'll make an abstract function called CalculateArea.
    }

    //we have a subclass called Square with its own unique characteristics, it inherits from Shape
    class Square : Shape
    {
        private int length;
        private int width;
        public Square() { } //empty constructor
        public Square(int length, int width) //overloading, we will pass in a length & width
        {
            this.length = length;
            this.width = width;
        }
        public override int CalculateArea() // Any functions inherited from an abstract or virtual class MUST contain the 'override' keyword
        {
            int area = this.length * this.width;
            return area;//and must return the same type
        }
    }

    class Triangle : Shape
    {
        private int baseLength;
        private int height;
        public Triangle() { }
        public Triangle(int baseLength, int height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        public override int CalculateArea()
        {
            int area = this.baseLength * this.height / 2;
            return area;
        }
    }

    class Circle : Shape
    {
        private double radius;
        public Circle() { }
        public Circle(double r)
        {
            this.radius = r;
        }
        public override int CalculateArea()
        {
            int area = (int)(Math.Pow(this.radius, 2) * Math.PI);
            return area;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Shape square = new Square(5, 10);   

            Shape triangle = new Triangle(10, 32);
            Shape circle = new Circle(7);

            Console.WriteLine("Area of square: {0} units", square.CalculateArea());
            Console.WriteLine("Area of triangle: {0} units", triangle.CalculateArea());
            Console.WriteLine("Area of circle: {0} units", circle.CalculateArea());

            Console.ReadLine();
        }
    }
}