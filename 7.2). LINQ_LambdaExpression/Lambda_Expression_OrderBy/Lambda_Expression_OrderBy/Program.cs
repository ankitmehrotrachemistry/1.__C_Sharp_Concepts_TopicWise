using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_OrderBy
{
    class Player
    {
        public int playerID { get; set; }
        public string playerName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>()
            {
                new Player{playerID = 1, playerName = "PIC4"},
                new Player{playerID = 5, playerName = "PIC1"},
                new Player{playerID = 2, playerName = "PIC3"},
                new Player{playerID = 8, playerName = "PIC2"},
            };

            var playerDetails = playerList.OrderBy(x => x.playerName);

            foreach (var value in playerDetails)
            {
                Console.WriteLine(value.playerID + " " + value.playerName);
            }
        }
    }
}
