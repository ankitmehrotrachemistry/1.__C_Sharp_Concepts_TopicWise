using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_List_ToDictionary
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList = new List<Player>()
            {
                new Player() {Id = 4, Name = "Suresh", Gender = "Male"},
                new Player() {Id = 2, Name = "Kamlesh", Gender = "Male"},
                new Player() {Id = 0, Name = "Akhil", Gender = "Male"},
                new Player() {Id = 8, Name = "Ankit", Gender = "Male"},
                new Player() {Id = 16, Name = "Riya", Gender = "Female"},
            };
            var player = playerList.ToDictionary(x => x.Id, x => x.Name);

            foreach (var plyr in player)
            {
                Console.WriteLine(plyr.Key + "\t" +plyr.Value);
            }
        }
    }
}
