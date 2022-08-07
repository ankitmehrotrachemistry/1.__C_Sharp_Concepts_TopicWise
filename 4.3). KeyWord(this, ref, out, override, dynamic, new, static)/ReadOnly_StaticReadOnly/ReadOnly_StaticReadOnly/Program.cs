using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_StaticReadOnly
{
    public class Program
    {
        public readonly int age = 18;

        public Program(int Age)
        {
            age = Age;
        }

        public void SetAge(Program p)
        {
            age = 10;
        }
        static void Main(string[] args)
        {
        }
    }
}
