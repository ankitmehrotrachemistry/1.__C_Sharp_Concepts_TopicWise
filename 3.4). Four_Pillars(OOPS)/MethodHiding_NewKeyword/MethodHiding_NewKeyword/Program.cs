using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding_NewKeyword
{
    public class ClassRoom
    {
        public void Display()
        {
            Console.WriteLine("Total Students are 2 -> ");
        }
    }
    public class Student : ClassRoom
    {
        public new void Display()
        {
            Console.WriteLine(" ---- Accessing the Hidden Member of Base Class by base Keyword ---- ");

            base.Display();
            Console.WriteLine("Name : Ankit, Age : 28 " +
                              "\nName : Soumya, Age : 26");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Display();
            Console.WriteLine(" ---- Accessing the Hidden Member of Base Class by Typecasting ---- ");
            ((ClassRoom)s).Display();
        }
    }
}
