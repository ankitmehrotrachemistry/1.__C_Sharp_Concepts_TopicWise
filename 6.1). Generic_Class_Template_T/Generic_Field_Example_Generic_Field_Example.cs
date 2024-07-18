using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Field_Example
{
    public class GenericClass<T>
    {
        public T Item { get; }
        public string Name { get; }
        public GenericClass(T item, string name)
        {
            Item = item;
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new GenericClass<int>(1000, "Thousand");
            Console.WriteLine($"{a.Item} : {a.Name}");

            var b = new GenericClass<string>("C# Ebook", "Dive in C#");
            Console.WriteLine($"{b.Item} : {b.Name}");
        }
    }
}