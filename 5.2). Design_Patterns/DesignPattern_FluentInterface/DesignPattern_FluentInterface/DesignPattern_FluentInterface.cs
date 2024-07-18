using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_FluentInterface
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int PlayerID { get; set; }
    }

    public class PlayerDetail
    {
        private Player player = new Player();
        public PlayerDetail NameOfPlayer(string playerName)
        {
            player.PlayerName = playerName;
            Console.WriteLine(playerName);
            return this;
        }
        public PlayerDetail IDOfPlayer(int playerID)
        {
            player.PlayerID = playerID;
            Console.WriteLine(playerID);
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PlayerDetail playerDetail = new PlayerDetail();
            playerDetail.NameOfPlayer("Ankit Mehrotra")
                        .IDOfPlayer(100);
        }
    }
}
