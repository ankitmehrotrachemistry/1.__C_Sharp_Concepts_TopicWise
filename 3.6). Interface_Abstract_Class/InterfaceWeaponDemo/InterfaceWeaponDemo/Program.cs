using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWeaponDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<IWeapon> weapon = new List<IWeapon>();

            weapon.Add(new Rifle());
            weapon.Add(new HandGun());

            foreach (IWeapon w in weapon)
            {
                w.Attack();
            }
        }
    }
}
