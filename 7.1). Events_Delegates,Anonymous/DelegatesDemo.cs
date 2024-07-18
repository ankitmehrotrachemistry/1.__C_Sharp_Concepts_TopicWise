using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        public delegate void AddNum(int a, int b);
        public delegate void SubNum(int a, int b);

        public void Sum(int a, int b)
        {
            Console.WriteLine("(5 + 4) = {0}", a+b);
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("(5 - 4) = {0}", a-b);
        }
        static void Main(string[] args)
        {
            Program P = new Program();

            AddNum del_Obj1 = new AddNum(P.Sum);
            SubNum del_Obj2 = new SubNum(P.Subtract);

            del_Obj1(5,4);
            del_Obj2(5,4);
        }
    }
}
