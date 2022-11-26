using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface Animal
    {
        void eat();
    }
    public class Dog : Animal
    {
        public void eat()
        {
            Console.WriteLine("Chew Chew..");
        }
    }
    public class Cat : Animal
    {
        public void eat()
        {
            Console.WriteLine("Huh Huh..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a;
            a = new Dog();
            a.eat();
            a = new Cat();
            a.eat();
        }
    }
}