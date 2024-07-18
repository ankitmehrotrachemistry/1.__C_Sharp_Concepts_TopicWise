using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_In_Class
{
    class Program
    {
        enum GameLevel
        {
            Easy,
            Medium,
            Hard
        }
        static void Main(string[] args)
        {
            GameLevel level1 = GameLevel.Easy;
            GameLevel level2 = GameLevel.Medium;
            GameLevel level3 = GameLevel.Hard;
            Console.WriteLine(level1);
            Console.WriteLine(level2);
            Console.WriteLine(level3);
        }
    }
}
