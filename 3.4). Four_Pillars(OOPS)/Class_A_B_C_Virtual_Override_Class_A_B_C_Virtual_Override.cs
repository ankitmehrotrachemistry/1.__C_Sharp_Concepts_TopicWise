﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_A_B_C_Virtual_Override
{
    class A
    {
        public virtual void Sound()
        {
            Console.WriteLine("Inside Class A");
        }
    }
    class B : A
    {
        public override void Sound()
        {
            Console.WriteLine("Inside Class B");
        }
    }
    class C : B
    {
        public void Sound()
        {
            Console.WriteLine("Inside Class C");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            A a1 = new A();
            a1.Sound();

            A a2 = new B();
            a2.Sound();

            A a3 = new C();
            a3.Sound();

        }
    }
}
