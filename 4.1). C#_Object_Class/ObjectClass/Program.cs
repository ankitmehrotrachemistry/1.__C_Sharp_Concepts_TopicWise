using System;

namespace ObjectClass
{
    public class Player
    {
        public int score;
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player P = new Player();
            P.score = 100;
            P.name = "Vatoke";

            Console.WriteLine(P.score);
            Console.WriteLine(P.name);
        }
    }
}
