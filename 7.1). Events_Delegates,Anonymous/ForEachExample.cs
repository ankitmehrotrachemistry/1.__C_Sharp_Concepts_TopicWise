using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "abc", "def", "ghi"};

            var actions = new List<Action>();

            foreach (string str in strings)
                actions.Add(() => { Console.WriteLine(str); });

            foreach (var action in actions)
                action();
        }
    }
}
