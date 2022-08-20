using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ToDictionary
{
    class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> player = new List<Player>()
            {
                new Player() { PlayerId = 12, PlayerName = "Akki Mittal"},
                new Player() { PlayerId = 10, PlayerName = "Ankit Mehrotra"},
                new Player() { PlayerId = 20, PlayerName = "Bunny Kumar"},
                new Player() { PlayerId = 50, PlayerName = "Visswa Kumar"}
            };

            var MyPlayer = player.ToDictionary(x => x.PlayerId, x => x.PlayerName)
                                 .OrderBy(x => x.Key);
            
            var MyPlayer1 = player.ToDictionary(x => x.PlayerId, x => x.PlayerName)
                                  .OrderByDescending(x => x.Value);

            foreach (var p in MyPlayer)
            {
                Console.WriteLine(p.Key + "\t" + p.Value);
            }

            Console.WriteLine("=====================================");
            Console.WriteLine("OrderBYDescending in Dictionary Value");
            Console.WriteLine("=====================================");

            foreach (var p1 in MyPlayer1)
            {
                Console.WriteLine(p1.Key +"\t" + p1.Value);
            }
        }
    }
}
