using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method_Variable
{
    public static class Shape
    {
        public static float PI = 3.14f;
        public static float areaCircle(int r)
        {
            return PI * r * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Circle is : " +Shape.areaCircle(5));
        }
    }
}