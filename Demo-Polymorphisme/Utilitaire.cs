using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme
{
    class Utilitaire : Vehicule
    {
        public override decimal PrixLocation { get { return 149.99M; } }

        public int capaciteCoffre { get; set; }

        public override void OuvrirCoffre()
        {
            Console.WriteLine("Descendre monte-charge. Ouvrir portes. Monter monte-charge.");
        }
    }
}
