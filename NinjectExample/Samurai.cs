using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectExample
{
    public class Samurai
    {
        private readonly IWeapon[] allWeapons;

        [Inject]
        public Samurai(IWeapon[] allWeapons)
        {
            this.allWeapons = allWeapons;
        }

        /*[Inject]
        public void Arm(IWeapon weapon)
        {
            this.weapon = weapon;
        }*/
        /*[Inject]
        public IWeapon Weapon { private get; set; }*/

        public void Attack(string target)
        {
            foreach(IWeapon weapon in allWeapons)
               Console.WriteLine(weapon.Hit(target));
        }
    }
}
