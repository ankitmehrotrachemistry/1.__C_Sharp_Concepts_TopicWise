using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_Implementation
{
    interface IPlayer
    {
        int GetScore();
    }
    class Program : IPlayer
    {
        int Score;

        Program(int score)
        {
            Score = score;
        }
        int IPlayer.GetScore()
        {
            return Score;
        }
        static void Main(string[] args)
        {
            Program pgm = new Program(100);
            IPlayer player = pgm;

            Console.WriteLine("Score is : {0}", player.GetScore() );
        }
    }
}
