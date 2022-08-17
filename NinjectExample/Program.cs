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

IKernel kernel = new StandardKernel(new TestModule());
IEnumerable<IWeapon> weapons = kernel.GetAll<IWeapon>();
foreach (var weapon in weapons)
    Console.WriteLine(weapon.Hit("злодея"));
