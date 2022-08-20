using System;
using System.Collections.Generic;

namespace InterfaceTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEnemy> players = new List<IEnemy>();

            players.Add(new Mage());
            players.Add(new Knight());
            players.Add(new Thief());

            foreach (IEnemy player in players)
            {
                player.Attack();
                player.Move();
            }
        }
    }
}
