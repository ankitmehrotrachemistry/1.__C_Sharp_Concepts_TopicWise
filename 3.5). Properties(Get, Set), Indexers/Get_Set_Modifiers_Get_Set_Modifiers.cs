using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Modifiers
{
    class Player
    {
        private static string playerName;
        public void Display()
        {
            Console.WriteLine("\nPlayer Name is :" +playerName);
        }
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Enter Player Name");
            player.PlayerName = Console.ReadLine();

            player.Display();
        }
    }
}
