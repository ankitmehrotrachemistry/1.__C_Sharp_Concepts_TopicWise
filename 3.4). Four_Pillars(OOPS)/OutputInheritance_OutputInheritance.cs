using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputInheritance
{
    class sample
    {
        public int i = 10;
        int j = 20;
        public void display()
        {
            Console.WriteLine("Base Class");
        }
    }

    class sample1 : sample
    {
        public int s = 40;
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample1 obj = new sample1();

            Console.WriteLine(obj.s);
            
            //Console.WriteLine(obj.j);  // Cannot access Private Integer j
            
            Console.WriteLine(obj.i);

            obj.display();

            Console.ReadLine();
        }
    }
}
