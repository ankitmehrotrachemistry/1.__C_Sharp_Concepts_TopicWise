using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Yumm....");
        }
    }

    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Bhow Bhow!!");
        }
    }

    public class Puppy : Dog
    {
        public void cry()
        {
            Console.WriteLine("Ainnnnnnnnn");
        }
    }
    class MultiLevelInhert
    {
        static void Main(string[] args)
        {
            Puppy p1 = new Puppy();

            p1.eat();
            p1.bark();
            p1.cry();
        }
    }
}
