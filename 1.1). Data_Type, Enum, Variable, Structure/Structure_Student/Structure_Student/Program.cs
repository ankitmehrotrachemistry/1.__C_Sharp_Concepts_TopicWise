using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Student
{
    struct Player
    {
        private int player_ID;
        private string player_Name;
        public int ID
        {
            get { return player_ID; }
            set { player_ID = value; }
        }
        public string Name
        {
            get { return player_Name; }
            set { player_Name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.ID = 100;
            player.Name = "Ankit Mehrotra";

            Console.WriteLine("ID is : " + player.ID + "\nName is : " + player.Name);
        }
    }
}
