using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_AbstractClass_Interface
{
    abstract class Abstract_Class
    {
        public abstract void Abstract_Method();
    }
    interface Interface
    {
        void Interface_Method();
    }
    class Inheritance_Abstract_Interface : Abstract_Class, Interface
    {
        public override void Abstract_Method()
        {
            Console.WriteLine("Implementing Abstract Method");
        }
        public void Interface_Method()
        {
            Console.WriteLine("Implementing Interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abstract_Class abst_class = new Inheritance_Abstract_Interface();
            Interface inter = new Inheritance_Abstract_Interface();

            abst_class.Abstract_Method();
            inter.Interface_Method();
        }
    }
}
