using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        protected int m_xpos;
        protected int m_ypos;
        public Shape()
        {
        }
        public Shape(int x, int y)
        {
            m_xpos = x;
            m_ypos = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a SHAPE at " + m_xpos + " " + m_ypos);
        }
    }
    public class Square : Shape
    {
        public Square()
        {
        }
        public Square(int x, int y) : base(x, y)
        {
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a SQUARE at " + m_xpos + " " + m_ypos);
        }
    }
    public class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(int x, int y) : base(x, y)
        {
        }
        public void FillCircle()
        {
            Console.WriteLine("Filling CIRCLE at " + m_xpos + " " + m_ypos);
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a CIRCLE at " + m_xpos + " " + m_ypos);
        }
    }
    public class CircleNonOverride : Shape
    {
        public CircleNonOverride()
        {
        }
        public CircleNonOverride(int x, int y) : base(x, y)
        {
        }
        public new void Draw()
        {
            Console.WriteLine("Drawing a CIRCLE at " + m_xpos + " " + m_ypos);
        }
    }
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Shape sh = new Shape(100, 100);
            sh.Draw();

            Square sq = new Square(200, 200);
            sq.Draw();

            Circle ci = new Circle(300, 300);
            ci.Draw();

            Console.WriteLine("\nPolymorphism:\n------------------");

            Shape[] shapes = new Shape[3];

            shapes[0] = new Shape(100, 100);
            shapes[1] = new Square(200, 200);
            shapes[2] = new Circle(300, 300);

            foreach (Shape shape in shapes)
                shape.Draw();

            Console.WriteLine("\nNon Override Class:\n------------------");

            Shape ciNon = new CircleNonOverride(250, 250);
            ciNon.Draw();

            Console.WriteLine("\nUp Casting:\n------------------");

            Shape shp = new Circle(320, 320);
            shp.Draw();

            Console.WriteLine("\nDown Casting:\n------------------");

            //Circle c=shp; this is illegal, we have to define shape is circle.
            Circle c = (Circle)shp;
            c.FillCircle();

            //shp is shape,if we call draw, Circle call draw because we defined shape as circle.
            //But shp don't know am i Circle, so we have to define shape is circle.
            ((Circle)shp).FillCircle();
        }
    }
}
