using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Proprietes
{
    class Produit
    {
        private decimal _price;

        public decimal Price
        {
            get
            {
                return _price-(_price*(Promo/100.00M));
            }

            set
            {
                if (value < 0) _price = 0;
                else _price = value;
            }
        }

        private int _promo;

        public int Promo
        {
            private get { return _promo; }
            set {
                if (value < 0) _promo = 0;
                else if (value > 100) _promo = 100;
                else _promo = value; 
            }
        }

    }
}
