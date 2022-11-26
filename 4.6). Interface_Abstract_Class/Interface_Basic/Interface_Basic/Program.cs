using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Basic
{
    interface IPlayer
    {
        void GetPlayerName();
    }
    class Player : IPlayer
    {
        public void GetPlayerName()
        {
            Console.WriteLine("Ankit");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.GetPlayerName();
        }
    }
}