using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_First_FirstOrDefault_List
{
    class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Player> playerList = new List<Player>()
            {
                new Player() {PlayerID = 10, PlayerName = "Chaaya"},
                new Player() {PlayerID = 4, PlayerName = "Zebra"},
                new Player() {PlayerID = 50, PlayerName = "Ankit"},
                new Player() {PlayerID = 32, PlayerName = "Elephant"},
            };

            var option1 = playerList.First();
            Console.WriteLine(option1.PlayerName);

            var option2 = playerList.First(x => x.PlayerID > 5);
            Console.WriteLine(option2.PlayerID);

            var option3 = playerList.First(x => x.PlayerName == "Elephant");
            Console.WriteLine(option3.PlayerID);

            var option4 = playerList.First(x => x.PlayerID == 100);
            Console.WriteLine(option4.PlayerID);

            var option5 = playerList.FirstOrDefault(x => x.PlayerName == "Harshit");
            Console.WriteLine(option5.PlayerName);
        }
    }
}
