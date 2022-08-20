using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTutorial
{
    interface IEnemy
    {
        float Hit { get; set; }
        float Health { get; set; }
        float Speed { get; set; }
        void Attack();
        void Move();
    }
}
