using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Of_Class_Demo
{
    class Player
    {
        public string playerName;
        public int playerId;
        public Player(string name, int Id)
        {
            this.playerName = name;
            this.playerId = Id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> player = new List<Player>();

            player.Add(new Player("Ankit", 580));
            player.Add(new Player("Anil", 456));
            player.Add(new Player("Kaushik", 984));
            player.Add(new Player("Kartik", 868));

            player.ForEach(delegate (Player p)
            {
                Console.WriteLine(p.playerName + " " +p.playerId);
            });
        }
    }
}
