using NinjectExample;
using Ninject;

/*var warrior1 = new Samurai(new Sword());
var warrior2 = new Samurai(new Shuriken());
warrior1.Attack("злодея");
warrior2.Attack("злодея");*/

/*IKernel kernel = new StandardKernel();
kernel.Bind<IWeapon>().To<Sword>();
var samurai = kernel.Get<Samurai>();
samurai.Attack("злодея");*/

/*IKernel kernel = new StandardKernel(new TestModule());
var samurai = kernel.Get<Samurai>();
samurai.Attack("злодея");*/

/*IKernel kernel = new StandardKernel(new TestModule());
IEnumerable<IWeapon> weapons = kernel.GetAll<IWeapon>();
foreach (var weapon in weapons)
    Console.WriteLine(weapon.Hit("злодея"));*/

/*IKernel kernel = new StandardKernel(new WarriorModule());
Samurai warrior = kernel.Get<Samurai>();
warrior.Attack("злодея");*/

bool useMeleeWeapons = false;
IKernel kernel = new StandardKernel(new WeaponModule(useMeleeWeapons));
Samurai warrior = kernel.Get<Samurai>();
warrior.Attack("злодея");

kernel.Load("*.dll");
kernel.Load(AppDomain.CurrentDomain.GetAssemblies());


kernel.Bind<IWeapon>().To<Shuriken>().Named("Strong");
kernel.Bind<IWeapon>().To<Sword>().Named("Weak");

kernel.Get<IWeapon>("Weak");