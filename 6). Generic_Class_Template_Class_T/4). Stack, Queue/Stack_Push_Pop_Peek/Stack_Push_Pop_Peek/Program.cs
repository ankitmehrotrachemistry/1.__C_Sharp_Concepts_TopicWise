using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Push_Pop_Peek
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> playerName = new Stack<string>();

            playerName.Push("Chaaya");
            playerName.Push("Sippra");
            playerName.Push("Ankita");
            playerName.Push("Sakshi");

            foreach (string name in playerName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek Elements is " +playerName.Peek());
            Console.WriteLine("Popping Out is " +playerName.Pop());
            Console.WriteLine("After Popping, Peek Element is : " +playerName.Peek());
        }
    }
}
