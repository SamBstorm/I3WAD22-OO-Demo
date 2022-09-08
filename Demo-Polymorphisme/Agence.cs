using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Polymorphisme
{
    class Agence
    {
        private List<Vehicule> _stock = new List<Vehicule>();
        public string Nom { get; set; }
        public string Ville { get; set; }

        public Vehicule this[string matricule]
        {
            get
            {
                //_stock.Find(v => v.Immatriculation == matricule);
                Vehicule location = null;
                foreach (Vehicule enStock in _stock)
                {
                    if (enStock.Immatriculation == matricule) location = enStock;
                }
                return location;
            }
        }

        public decimal Louer(string matricule, int nbJours, out Vehicule location)
        {
            location = this[matricule];
            return location.PrixLocation* nbJours;
        }

        public void Recuperer(Vehicule vehicule)
        {
            _stock.Add(vehicule);
        }
    }
}
