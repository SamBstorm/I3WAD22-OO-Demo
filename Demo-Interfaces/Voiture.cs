using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    class Voiture : Vehicule, IRoule
    {
        public void Roule()
        {
            Console.WriteLine("Vroum, vroum!");
        }
    }
}
