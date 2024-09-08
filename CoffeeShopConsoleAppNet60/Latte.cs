using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Latte : Coffee, IMilk
    {
        private const int BasePrice = 40;

        public Latte(int discount) : base(discount) { }

        public override int Price()
        {
            return BasePrice - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public int mlMilk()
        {
            return 200;
        }
    }
}
