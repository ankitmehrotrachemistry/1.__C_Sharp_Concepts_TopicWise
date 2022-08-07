using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_Constructor
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int PlayerID { get; set; }
        public Player()
        {
            
        }
        public Player(string playerName)
        {
            this.PlayerName = playerName;
            Console.WriteLine(PlayerName);
        }
        public Player(string playerName, int playerID)
        {
            this.PlayerName = playerName;
            this.PlayerID = playerID;
            Console.WriteLine(PlayerName + " " + PlayerID);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player();

            var player2 = new Player("Ankit");

            var player3 = new Player("Chaaya", 12);
        }
    }
}
