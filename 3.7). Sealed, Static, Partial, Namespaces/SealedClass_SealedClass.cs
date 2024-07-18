using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public sealed class Circle
    {
        private double radius = 4.0;
        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine(circle.Calculate(r => 3.14 * r * r));

            
        }
    }
}





