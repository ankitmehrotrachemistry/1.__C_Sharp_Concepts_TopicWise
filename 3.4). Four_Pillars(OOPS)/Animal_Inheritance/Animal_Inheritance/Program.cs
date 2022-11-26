using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheritance
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
        public void Walk()
        {
            Console.WriteLine("Animal Walk");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
        public void Walk()
        {
            Console.WriteLine("Dog Walk");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.WriteLine("---------------------");
            d.Sound();
            d.Walk();
            ((Animal)d).Walk();
            ((Animal)d).Sound();

            Animal a = new Animal();
            Console.WriteLine("---------------------");
            a.Sound();
            a.Walk();

            Animal a1 = new Dog();
            Console.WriteLine("---------------------");
            a1.Walk();
            a1.Sound();

            Console.WriteLine("---------------------");

        }
    }
}
