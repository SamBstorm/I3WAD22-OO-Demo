using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConstructeurHeritage
{
    class Maison : Charpente
    {
        public int NombrePieces { get; set; }
        public Maison(int longueur, int largeur, int hauteur, int nombrePieces):base(longueur,largeur,hauteur)
        {
            this.NombrePieces = nombrePieces;
            Console.WriteLine($"Voici ma maison de {this.NombrePieces} pièces, de {this.Largeur}m sur {this.Longueur}m, avec {this.Hauteur}m de haut!");
        }
    }
}
