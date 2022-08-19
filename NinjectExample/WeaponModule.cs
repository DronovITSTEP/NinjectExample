using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace NinjectExample
{
    internal class WeaponModule : NinjectModule
    {
        private readonly bool useMeleeWeapons;
        public WeaponModule(bool useMeleeWeapons)
        {
            this.useMeleeWeapons = useMeleeWeapons;
        }
        public override void Load()
        {
            if (useMeleeWeapons)
                Bind<IWeapon>().To<Sword>();
            else
                Bind<IWeapon>().To<Shuriken>();
        }
    }
}
