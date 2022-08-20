using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Class_List_FindAll
{
    public class HockeyTeam
    {
        private string _name;
        private int _founded;

        public HockeyTeam(string name, int year)
        {
            _name = name;
            _founded = year;
        }
        public string Name
        {
            get { return _name; }
        }
        public int Founded
        {
            get { return _founded; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            List<HockeyTeam> teams = new List<HockeyTeam>();

            teams.AddRange(new HockeyTeam[] {
                                               new HockeyTeam("Virat Kohli", 1924),
                                               new HockeyTeam("Ankit Mehrotra", 2008),
                                               new HockeyTeam("Chinging Pan", 1980),
                                               new HockeyTeam("Bastima Rao", 2002)
                                            });
            int[] years = { 1920, 2000, 2004, 2016};

            int yearFounded = years[rand.Next(0, years.Length)];

            Console.WriteLine("Team before {0} ", yearFounded);

            foreach (var team in teams.FindAll(x => x.Founded <= yearFounded))
                Console.WriteLine("{0}:{1}", team.Name, team.Founded);
        }
    }
}
