using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial
{
    class Knight : IEnemy
    {
        public float Hit { get; set; } = 15;
        public float Health { get; set; } = 15;
        public float Speed { get; set; } = 15;

        //public float Armor { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Knight slashes his two handed sword for { Hit } points of damage!");
        }

        public void Move()
        {
            Console.WriteLine($"Knight slowly moves his in his sturdy armour { Speed } meters away");
        }

        /*public void Protection()
        {
            Console.WriteLine($"Knight has { Armor } added protection");
        }*/

    }
}
