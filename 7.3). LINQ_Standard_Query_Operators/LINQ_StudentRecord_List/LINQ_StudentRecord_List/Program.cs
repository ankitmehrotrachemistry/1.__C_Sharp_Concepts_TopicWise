using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_StudentRecord_List
{
    public class Players
    {
        public string PlayerName { get; set; }
        public int PlayerID { get; set; }
        public int Score { get; set; }
        public List<Players> GetPlayerDetails()
        {
            List<Players> playersList = new List<Players>();

            playersList.Add(new Players { PlayerName = "Chaaya", PlayerID = 100, Score = 100});
            playersList.Add(new Players { PlayerName = "Kajal", PlayerID = 10, Score = 10 });
            playersList.Add(new Players { PlayerName = "Ankit", PlayerID = 50, Score = 50 });
            playersList.Add(new Players { PlayerName = "Vidyut", PlayerID = 40, Score = 40 });

            return playersList;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Players();
            players.GetPlayerDetails()
                .GroupBy(play => play.PlayerID)
                .OrderByDescending(x => x.Key).Skip(2)  // Second Largest Element in List
                .Take(1)
                .SelectMany(s => s)
                .ToList()
                .ForEach(p =>
                Console.WriteLine($"ID  : {p.PlayerID}, Name : {p.PlayerName}, Score : {p.Score} "));
        }
    }
}
