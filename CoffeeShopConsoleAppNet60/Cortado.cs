﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Cortado : Coffee, IMilk
    {
        public override int Price()
        {
            return base.Price()+5;
        }

        public override string Strength()
        {
            return "Medium";
        }

       public int mlMilk()
        {
            return 40;
        }
    }
}
