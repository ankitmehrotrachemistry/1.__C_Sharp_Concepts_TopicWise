using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initialization
{
    class Player
    {
        public int PlayerID { get; set; }
        public string PlayerSymbol { get; set; }
        public int PlayerScore { get; set; }
        public string PlayerName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                PlayerID = 100,
                PlayerSymbol = "XO4",
                PlayerScore = 200,
                PlayerName = "Ankit"
            };

            Console.WriteLine("-------- Printing all Player Details --------");

            Console.WriteLine("Player ID is " +player.PlayerID);
            Console.WriteLine("Player Symbol is " + player.PlayerSymbol);
            Console.WriteLine("Player Score is " + player.PlayerScore);
            Console.WriteLine("Player Name is " + player.PlayerName);
        }
    }
}
