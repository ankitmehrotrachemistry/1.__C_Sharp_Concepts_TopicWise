using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    public class Game
    {
        public int score = 200;
        public float highScore = 5000;
    }

    public class ClashRoyale : Game
    {
        public float highScore = 4000;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClashRoyale cr1 = new ClashRoyale();

            //ClashRoyale cr2 = new Game();

            Game g1 = new ClashRoyale();

            Console.WriteLine("High score is:-" +g1.highScore);
            Console.WriteLine("Score is :- " +cr1.score);
            Console.WriteLine("highScore is :- " +cr1.highScore);
        }
    }
}
