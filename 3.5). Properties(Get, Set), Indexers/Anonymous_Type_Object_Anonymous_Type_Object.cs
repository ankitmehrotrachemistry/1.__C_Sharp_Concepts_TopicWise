using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new { player_Id = 100, player_name = "Ankit"};
            Console.WriteLine("Player ID is : " +player.player_Id);
            Console.WriteLine("Player Name is : " +player.player_name);
        }
    }
}