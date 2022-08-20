using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Multiply
{
    class Program
    {
        public delegate void Multiply(int a, int b);
        public delegate void Multiply1(double a, double b);
        public void Product(int a, int b)
        {
            Console.WriteLine("Product is = {0}", a*b);
        }
        public void Product1(double a, double b)
        {
            Console.WriteLine("Product of Double is {0}", a*b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Multiply mulDelegate = new Multiply(p.Product);
            mulDelegate(5,8);

            Multiply1 mulDelegate1 = new Multiply1(p.Product1);
            mulDelegate1(5.2, 3.4);
        }
    }
}
