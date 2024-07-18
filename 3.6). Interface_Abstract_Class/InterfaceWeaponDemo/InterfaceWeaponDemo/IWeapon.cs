using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWeaponDemo
{
    interface IWeapon
    {
        float Power { get; set; }
        float Range { get; set; }
        float ShotToKill { get; set; }
        void Attack();
    }
}
