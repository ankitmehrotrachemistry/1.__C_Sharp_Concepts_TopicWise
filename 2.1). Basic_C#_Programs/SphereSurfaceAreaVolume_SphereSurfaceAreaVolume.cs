using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereSurfaceAreaVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14;
            float radius = Convert.ToSingle(Console.ReadLine());
            double SurfaceArea, Volume;

            SurfaceArea = 4 * PI * (radius*radius);
            Volume = (4 / 3) * PI * (radius * radius * radius);

            // {0} is the placeholder for the first argument after the format string,
            // {1} is the second, and so on.
            // For example, Console.WriteLine("{0}, {1}", "bleh", 53); would result in
            // this line being written: bleh, 53 .

            Console.WriteLine("The Surface Area is {0}", SurfaceArea);
            Console.WriteLine("The Volume is {0}", Volume);

            Console.ReadLine();
        }
    }
}
