using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_AddLast_AddBefore_AddAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerName = new LinkedList<string>();

            playerName.AddLast("Ankita");
            playerName.AddLast("Chaaya");
            playerName.AddLast("Sakshi");
            playerName.AddLast("Sippra");
            playerName.AddLast("Divya");

            Console.WriteLine("LinkedList is ");
            foreach (var name in playerName)
            {
                Console.WriteLine(name);
            }

            LinkedListNode<string> node = playerName.Find("Chaaya");

            Console.WriteLine("New LinkedList after adding is ");

            playerName.AddBefore(node, "John");
            playerName.AddAfter(node, "Ankit");

            foreach (var name in playerName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
