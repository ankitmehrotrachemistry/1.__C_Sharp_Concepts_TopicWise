using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Of_Class
{
    interface IPlayer
    {
        string PlayerDetails();
        string Name { get; set; }
    }
    class HockeyPlayer : IPlayer, IComparable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public HockeyPlayer(string name)
        {
            this.Name = name;
        }
        public string PlayerDetails()
        {
            return " My Player Name is " + this.Name;
        }

        public int CompareTo(object obj)
        {
            if (obj is IPlayer)
                return this.Name.CompareTo((obj as IPlayer).Name);
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<HockeyPlayer> hockeyPlayer = new List<HockeyPlayer>();

            hockeyPlayer.Add(new HockeyPlayer("Chaaya"));
            hockeyPlayer.Add(new HockeyPlayer("Ankit"));
            hockeyPlayer.Add(new HockeyPlayer("Babita"));
            hockeyPlayer.Add(new HockeyPlayer("Suruchi"));

            hockeyPlayer.Sort();

            foreach (HockeyPlayer player in hockeyPlayer)
                Console.WriteLine(player.PlayerDetails());
        }
    }
}
