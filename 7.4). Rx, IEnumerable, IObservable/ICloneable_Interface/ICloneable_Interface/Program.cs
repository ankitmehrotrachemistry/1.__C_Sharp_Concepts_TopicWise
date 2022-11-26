using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable_Interface
{
    class Car : ICloneable
    {
        int width;
        public Car(int width)
        {
            this.width = width;
        }
        public Object Clone()
        {
            return new Car(this.width);
        }
        public override string ToString()
        {
            return string.Format("Width of Car = {0}", this.width);
        }
    }
    class Program
    {
        // ICloneable interface creates a copy of the exisiting object i.e a clone.
        // It only has a single method : Clone() that creates a new object COpy.
        static void Main(string[] args)
        {
            Car car1 = new Car(1200);
            Car car2 = car1.Clone() as Car;

            Console.WriteLine("{0}mm", car1);
            Console.WriteLine("{0}mm", car2);
        }
    }
}
