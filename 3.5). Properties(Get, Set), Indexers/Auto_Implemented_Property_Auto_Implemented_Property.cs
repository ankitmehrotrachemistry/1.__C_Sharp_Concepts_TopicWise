using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Implemented_Property
{
    class Player
    {
        public int ID { get; set; }
        public string PlayerName { get; set; }
        public Player(int id, string name)
        {
            ID = id;
            PlayerName = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(12, " Ankit");
            Console.Write(p.ID);
            Console.WriteLine(p.PlayerName);

            var player = new Player(100, " Alok");
            Console.Write(player.ID);
            Console.WriteLine(player.PlayerName);
        }
    }
}
