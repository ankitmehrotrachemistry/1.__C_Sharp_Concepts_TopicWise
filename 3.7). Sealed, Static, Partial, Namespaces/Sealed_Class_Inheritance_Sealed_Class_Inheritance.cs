using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Inheritance
{
    sealed public class Shape
    {
        public void Area()
        {
            Console.WriteLine("Area of Shape");
        }
    }
    public class Rectangle : Shape // Cannot inherit (derive) from Sealed Class
    {
        public void AreaRectangle()
        {
            Console.WriteLine("Area of Rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Area(); // Gives Error
            rect.AreaRectangle();
        }
    }
}