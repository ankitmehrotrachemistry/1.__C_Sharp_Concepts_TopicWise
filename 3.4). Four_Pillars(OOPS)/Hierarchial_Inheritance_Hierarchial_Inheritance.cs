using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchial_Inheritance
{
    public class Parent
    {
        public string ParentName()
        {
            return "Amit";
        }
    }
    public class Son : Parent
    {
        public string SonName()
        {
            return "Archit";
        }
    }
    public class Daughter : Parent
    {
        public string DaughterName()
        {
            return "Akriti";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Son s = new Son();
            Console.WriteLine("Son name is : " +s.SonName() + " and parent name is :" +s.ParentName());
            Daughter d = new Daughter();
            Console.WriteLine("Daughter name is : " +d.DaughterName() + " and daughter name is : " +d.ParentName());
        }
    }
}