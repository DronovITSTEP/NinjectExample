using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    public class Sword : IWeapon
    {
        public string Hit(string target)
        {
           return $"Разрубил {target} пополам.";
        }
    }
}
