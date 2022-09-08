using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme
{
    class Familial : Vehicule
    {
        public override decimal PrixLocation { get { return 299.99M; } }

        public int nombreSieges { get; set; }

        public override void OuvrirCoffre()
        {
            Console.WriteLine("Déverrouiller le capot du coffre.");
        }
    }
}
