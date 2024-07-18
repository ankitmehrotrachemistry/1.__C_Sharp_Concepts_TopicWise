using System;

namespace ParameterConstructor
{
    public class Player
    {
        public string playername;
        public int elixir;
        public string rarity;

        public Player(string s1, int i, string s2) // Parameterised Constructor
        {
            playername = s1;
            elixir = i;
            rarity = s2;
        }
        public void displayplayerinfo()
        {
            Console.WriteLine(playername + " " + elixir + " " + rarity);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Valkyrie",4,"Rare");
            Player p2 = new Player("Wizard",5,"Rare");

            p1.displayplayerinfo();
            p2.displayplayerinfo();
        }
    }
}
