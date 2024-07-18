using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism_Virtual_Override
{
    public class Parrot
    { 
        // To override base class method in a derived class, you have to declare a base class method as virtual
        public virtual void Sound() 
        {
            Console.WriteLine("Inside Parrot");
        }
    }
    public class P1 : Parrot
    {
        // To override base class method in a derived class, you have to declare a derived class method as override
        public override void Sound()
        {
            Console.WriteLine("Inside P1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parrot p = new P1(); 
            p.Sound(); 

            ((P1)p).Sound(); 

            p = new P1(); 
            p.Sound(); 

            P1 p1 = new P1();
            p1.Sound();

            Parrot parrot = new Parrot();
            parrot.Sound(); 
        }
    }
}

