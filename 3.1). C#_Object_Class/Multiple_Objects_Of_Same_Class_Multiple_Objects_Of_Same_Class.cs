using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Objects_Of_Same_Class
{
    class Box
    {
        public double length;
        public double breadth;
        public double height;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();

            box1.length = 2.0; // Same as Line 30
            box1.breadth = 4.0;
            box1.height = 8.0;

            box2.length = 4.0;
            box2.breadth = 4.4;
            box2.height = 4.8;

            box1.length = 100.0; // No Issues here

            double volume;

            volume = box1.length * box1.breadth * box1.height;
            Console.WriteLine("Box1 Volume is " +volume);
            
            volume = box2.length * box2.breadth * box2.height;
            Console.WriteLine("Box2 Volume is " + volume);
        }
    }
}
