using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Cortado : Coffee, IMilk
    {
        // Konstant, der holder basisprisen for Cortado
        private const int BasePrice = 25;

        // Konstruktør, der kalder Coffee's konstruktør og sætter rabatten
        public Cortado(int discount) : base(discount) { }
        
        public override int Price()
        {
            return BasePrice - Discount;        }

        public override string Strength()
        {
            return "Medium";
        }
        // Implementerer mlMilk-metoden fra IMilk-interfacet
        public int mlMilk()
        {
            return 40;
        }
    }
}
