using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectExample
{
    internal class WeakAttack
    {
        readonly IWeapon _weapon;
        public WeakAttack([Named("Weak")] IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void Attack(string victim)
        {
            Console.WriteLine(_weapon.Hit(victim));
        }
    }
}
