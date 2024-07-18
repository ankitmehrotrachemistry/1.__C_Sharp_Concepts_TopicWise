using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Override_Demo
{
    public class Parrot
    {
        public void Sound()
        {
            Console.WriteLine("Inside Parrot");
        }
    }
    public class P1 : Parrot
    {
        public new void Sound() //  If you make it new that is the same as if it was not virtual.
                            // Same output as : public new void Sound()
        {
            Console.WriteLine("Inside P1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parrot p = new P1(); // An instance of the Child class will be created.
            p.Sound(); // It will call the members from Parent 

            ((P1)p).Sound(); //  If you want to use the members of child you would have to cast.

            p = new P1(); // An instance of the Child class will be created.
            p.Sound(); // It will call the members from Parent 

            P1 p1 = new P1();
            p1.Sound();
        }
    }
}