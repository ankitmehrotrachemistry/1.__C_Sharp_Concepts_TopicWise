using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_T_List_Class
{
    public class CricketTeam
    {
        private string _name;
        private int _score;
        public CricketTeam(string name, int score)
        {
            _name = name;
            _score = score;
        }
        public string Name { get { return _name; } }
        public int Score { get { return _score; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            List<CricketTeam> teams = new List<CricketTeam>();

            teams.AddRange(new CricketTeam[] 
                            {
                                new CricketTeam("Virat Kohli", 186),
                                new CricketTeam("Sachin Tendulkar", 200),
                                new CricketTeam("Virendra Sehwag", 219),
                                new CricketTeam("Rohit Sharma", 264),
                                new CricketTeam("Saurabh Ganguly", 186),
                            });
            int[] runs = { 180,190,200,240,260};

            int runsLessThanScore = runs[rand.Next(0, runs.Length)];

            Console.WriteLine("Runs before {0} : ", runsLessThanScore);

            foreach (var run in teams.FindAll(x => x.Score <= runsLessThanScore))
                Console.WriteLine("{0}:{1}", run.Name, run.Score);
        }
    }
}
