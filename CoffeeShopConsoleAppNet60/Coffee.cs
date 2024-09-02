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
        //// Instansvariabel til at holde rabatten
        public int _discount;

        // Property til at tilgå og sætte rabatten
        public int Discount
        {
            get { return _discount; }
            private set
            {
                // Tjekker om rabatten overstiger 5 DKK
                if (value > 5)
                {
                    // Smider en fejl hvis rabatten er større end 5 DKK
                    throw new ArgumentOutOfRangeException("Discount cannot be greater than 5 DKK.");
                }
                // Hvis rabatten er gyldig, gemmes den i _discount
                _discount = value;
                
            }
        }

        //Konstruktør initialiserer rabatten
        public Coffee(int discount)
        {
            Discount = discount;
        }

        public virtual int Price()
        {
            return 20;
        }

        //Abstrakt metode til implementering af styrke for kaffer
        public abstract string Strength();
        
       //rabat
       
    }
}
