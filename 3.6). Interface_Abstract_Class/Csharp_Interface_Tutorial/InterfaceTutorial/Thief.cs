using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial
{
    class Thief : IEnemy
    {
        public float Hit { get; set; } = 5;
        public float Health { get; set; } = 5;
        public float Speed { get; set; } = 5;

       //public int Money { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Thief pulls his two dagers doing { Hit } points of damage!");
        }

        public void Move()
        {
            Console.WriteLine($"Thief quietly sneaks away unnoticed { Speed } meters away");
        }

        /*
        public void Steal()
        {
            Console.WriteLine($"Thief now has { Money } coins");
        }
        */
    }
}
