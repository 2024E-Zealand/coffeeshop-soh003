using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount) : base(discount) { }

        public override string Strength()
        {
           return "Strong";
        }

        public override int Price()
        {
            return base.Price()- Discount;
        }


    }

    

}
