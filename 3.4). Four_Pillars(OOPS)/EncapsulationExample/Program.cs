using System;
namespace EncapsulationExample
{
    class Player
    {
        public string playerID {get; set; }
        public string playerName {get; set; }
        public int playerLevel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player P = new Player();
            P.playerID = "2";
            P.playerName = "Ankit";
            P.playerLevel = 10;
            Console.WriteLine("Player ID is " + P.playerID);
            Console.WriteLine("Player Name is " + P.playerName);
            Console.WriteLine("Player Level is " + P.playerLevel);
        }
    }
}