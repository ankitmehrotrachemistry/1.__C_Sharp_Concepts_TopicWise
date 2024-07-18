using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Automatic_Properties
{
    class Program
    {
        private string playerName;
        private string playerID;
        private int playerScore;
        public string Name
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public string ID
        {
            get { return playerID; }
            set { playerID = value; }
        }
        public int Score
        {
            get { return playerScore; }
            set { playerScore = value; }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Name = "Ankit Mehrotra";
            p.ID = "CO-4";
            p.Score = 1120580;
            // String Interpolation in C# using Dollar $ Sign
            Console.WriteLine($"Player Name is : {p.Name}, Player ID is {p.ID}, Player Score is {p.Score}");
        }
    }
}
