using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConstructeurHeritage
{
    class Charpente : Fondation
    {
        public int Hauteur { get; set; }

        public Charpente(int longueur, int largeur, int hauteur): base(longueur, largeur)
        {
            this.Hauteur = hauteur;
            Console.WriteLine("La charpente est finie!");
        }
    }
}
