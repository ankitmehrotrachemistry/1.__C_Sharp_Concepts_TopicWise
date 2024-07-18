using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors_Basic
{
    public class Player
    {
        public Player()
        {
            Console.WriteLine("Constructor Called");
        }
        ~Player()
        {
            Console.WriteLine("Destructor Called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
        }
    }
}
