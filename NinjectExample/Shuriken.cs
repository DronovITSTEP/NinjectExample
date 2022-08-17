using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    public class Shuriken : IWeapon
    {
        public string Hit(string target)
        {
            return "Пробил броню " + target;
        }
    }
}
