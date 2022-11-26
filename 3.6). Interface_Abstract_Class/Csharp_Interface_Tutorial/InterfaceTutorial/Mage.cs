using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial
{
    class Mage : IEnemy
    {
        public float Hit { get; set; } = 10;
        public float Health { get; set; } = 10;
        public float Speed { get; set; } = 10;

        //public float Mana { get; set; }
        public void Attack()
        {
            Console.WriteLine($"Mage send a giant fire ball doing { Hit } damage!");
        }

        public void Move()
        {
            Console.WriteLine($"Mage pulls his robes and runs at { Speed } meters away");
        }

        /*public void Meditate()
        {
            Console.WriteLine($"Mage meditaes and now has { Mana } mana!");
        }*/

    }
}
