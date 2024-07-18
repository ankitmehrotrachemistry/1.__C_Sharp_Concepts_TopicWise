using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT_Stack
{
    public class Generic<T>
    {
        Stack<T> stk = new Stack<T>();

        public void push(T obj)
        {
            stk.Push(obj);
        }
        public T pop()
        {
            T obj = stk.Pop();
            return obj;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> gen = new Generic<int>();
            Generic<string> gen1 = new Generic<string>();

            gen.push(10);
            gen1.push("Ankit");

            Console.WriteLine(gen.pop());
            Console.WriteLine(gen1.pop());
        }
    }
}
