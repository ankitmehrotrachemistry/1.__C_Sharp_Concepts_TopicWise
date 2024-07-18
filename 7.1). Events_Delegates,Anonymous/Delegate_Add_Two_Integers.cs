using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Add_Two_Integers
{
    class Program
    {
        public delegate void AddNumber(int x, int y);
        public void AddFormula(int x, int y)
        {
            Console.WriteLine("[{0} + {1}] = [{2}]", x,y, x+y);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            AddNumber add = new AddNumber(p.AddFormula);

            add(120,80);
        }
    }
}
