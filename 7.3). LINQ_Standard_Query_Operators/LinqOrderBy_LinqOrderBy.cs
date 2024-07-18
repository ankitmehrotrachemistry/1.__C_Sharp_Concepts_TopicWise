using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOrderBy
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Player> playerList = new List<Player>()
            {
                new Player() { PlayerID = 1, PlayerName = "Baby", PlayerScore = 10},
                new Player() { PlayerID = 2, PlayerName = "Chaaya", PlayerScore = 20},
                new Player() { PlayerID = 3, PlayerName = "Ankush", PlayerScore = 30},
                new Player() { PlayerID = 4, PlayerName = "Ankit", PlayerScore = 40},
                new Player() { PlayerID = 5, PlayerName = "Ajay", PlayerScore = 50}
            };

            var orderByResult = from p in playerList
                                orderby p.PlayerName
                                select p;

            var orderByDescendingResult = from p in playerList
                                          orderby p.PlayerName descending
                                          select p;

            Console.WriteLine("Ascending Order is : ");

            foreach (var std in orderByResult)
                Console.WriteLine(std.PlayerName);

            Console.WriteLine("Descending Order is : ");

            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.PlayerName);

        }
    }
}