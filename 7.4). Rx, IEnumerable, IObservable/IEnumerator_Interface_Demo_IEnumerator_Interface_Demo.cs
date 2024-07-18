using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator_Interface_Demo
{
    class Program
    {
        static void Write(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                int value = e.Current;
                Console.WriteLine(value);
            }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            List<int>.Enumerator e = list.GetEnumerator();

            Write(e);
        }
    }
}
