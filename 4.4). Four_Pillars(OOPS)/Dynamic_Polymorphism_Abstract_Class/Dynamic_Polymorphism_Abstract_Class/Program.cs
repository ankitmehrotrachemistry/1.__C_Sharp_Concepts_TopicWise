using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism_Abstract_Class
{
    abstract class Shape
    {
        public abstract int Area();
    }
    class Rectangle : Shape
    {
        private int length;
        private int breadth;
        
        public Rectangle(int a, int b)
        {
            length = a;
            breadth = b;
        }
        public override int Area()
        {
            return length * breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4,5);
            double ar = rect.Area();

            Console.WriteLine("Area of Rectangle is {0}", ar);
        }
    }
}
