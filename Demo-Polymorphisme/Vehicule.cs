using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme
{
    abstract class Vehicule
    {
        public string Immatriculation { get; set; }
        public string Couleur { get; set; }
        public string Moteur { get; set; }
        public string Marque { get; set; }
        public abstract decimal PrixLocation { get; }

        public abstract void OuvrirCoffre();
    }
}
