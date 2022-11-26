using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputClassDerived
{
    class Program
    {
        public static void Main()
        {
            classA a = new classC();
            Console.WriteLine(a.Print());
        }

        public class classA
        {
            public virtual string Print()
            {
                return "classA";
            }
        }

        public class classB : classA
        {
            public override string Print()
            {
                return "classB";
            }
        }

        public class classC : classB
        {
            public new string Print()
            {
                return "ClassC";
            }
        }
    }
}
