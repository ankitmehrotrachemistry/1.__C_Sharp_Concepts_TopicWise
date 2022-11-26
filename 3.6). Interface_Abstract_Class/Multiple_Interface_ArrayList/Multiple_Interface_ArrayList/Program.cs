using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interface_ArrayList
{
    interface I1
    {
        void Name();
    }
    class Player : I1
    {
        public void Name()
        {
            ArrayList playerList = new ArrayList();

            playerList.Add("Dravid");
            playerList.Add("Tendulkar");
            playerList.Add("Sehwag");
            playerList.Add("Ganguly");

            Console.WriteLine("Player Name : ");
            foreach (var play in playerList)
            {
                Console.WriteLine(play);
            }
        }
    }

    interface I2
    {
        void HighScore();
    }
    class Score : I2
    {
        public void HighScore()
        {
            ArrayList playerScore = new ArrayList();

            playerScore.Add("100");
            playerScore.Add("200");
            playerScore.Add("300");
            playerScore.Add("400");

            Console.WriteLine("Player High Score : ");
            foreach (var scr in playerScore)
            {
                Console.WriteLine(scr);
            }
        }
    }

    class PlayerDetails : I1, I2
    {
        Player p = new Player();
        Score s = new Score();

        public void Name()
        {
            p.Name();
        }
        public void HighScore()
        {
            s.HighScore();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PlayerDetails playerDetails = new PlayerDetails();

            playerDetails.Name();
            playerDetails.HighScore();
        }
    }
}
