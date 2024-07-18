using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    abstract class Figure
    {
        public int Dimension;
        public abstract double Area();
    }
    class Square : Figure
    {
        public override double Area()
        {
            return Dimension * Dimension;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure fig = new Square();
            fig.Dimension = 10;
            Console.WriteLine("Area of Square is : " +fig.Area());
        }
    }
}