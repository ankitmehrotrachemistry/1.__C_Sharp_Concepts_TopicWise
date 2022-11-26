using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Covariance
{
    public class Animal
    {
        protected int age;
        protected void displayAge(int age)
        {
            this.age = age;
            Console.WriteLine(this.age);
        }
    }
    public class Dog : Animal
    {
        public string color;
        public void displayColor()
        {
            displayAge(99);
            Console.WriteLine(this.color);
        }
    }
    class Program
    {
        public delegate Animal AnimalDelegate();
        static Dog newDog()
        {
            Dog d = new Dog();

            d.color = "white";
            d.displayColor();

            return d;
        }
        static void Main(string[] args)
        {
            AnimalDelegate an = newDog;
            an();

            Console.ReadKey(true);
        }
    }
}
