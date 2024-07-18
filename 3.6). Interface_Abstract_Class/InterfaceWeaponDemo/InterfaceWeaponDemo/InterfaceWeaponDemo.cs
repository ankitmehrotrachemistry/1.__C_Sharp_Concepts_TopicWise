using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWeaponDemo
{
    class HandGun : IWeapon
    {
        public float Power { get; set; } = 5;
        public float Range { get; set; } = 5;
        public float ShotToKill { get; set; } = 5;
        public void Attack()
        {
            Console.WriteLine($"HandGun has {Power} Power");
        }
    }
}
