using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPush
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack gameStack = new Stack();
            gameStack.Push("Bounce Ball");
            gameStack.Push("Contra");
            gameStack.Push("Prince of Persia");
            gameStack.Push("Street Fighter");
            gameStack.Push("Pacman");
            gameStack.Push("The Legend Of Zelda");
            gameStack.Push(2048);
            gameStack.Push(4.5f);
            foreach (var elem in gameStack)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
