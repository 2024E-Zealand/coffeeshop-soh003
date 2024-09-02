using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public virtual int Price()
        {
            return 20;
        }

        //Abstrakt metode til implementering af styrke for kaffer
        public abstract string Strength();
        
       
    }
}
