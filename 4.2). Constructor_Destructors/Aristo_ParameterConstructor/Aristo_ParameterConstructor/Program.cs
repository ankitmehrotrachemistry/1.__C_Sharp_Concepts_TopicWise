using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aristo_ParameterConstructor
{
    class Program
    {
        public string playerName;
        public int playerID;

        public Program(Program p)
        {
            playerName = p.playerName;
            playerID = p.playerID;
        }
        Program(String playerName, int playerID)
        {
            this.playerName = playerName;
            this.playerID = playerID;
        }
        static void Main(string[] args)
        {
            Program p = new Program("Ankit",107804);

            Program p1 = new Program(p);

            Console.WriteLine("Player Name is : " +p.playerName + " and Player ID is : " +p.playerID);
        }
    }
}
