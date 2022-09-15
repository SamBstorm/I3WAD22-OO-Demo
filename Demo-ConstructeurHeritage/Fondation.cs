using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ConstructeurHeritage
{
    class Fondation
    {
        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public Fondation(int mesure1, int mesure2)
        {
            if (mesure1 > mesure2)
            {
                this.Longueur = mesure1;
                this.Largeur = mesure2;
            }
            else
            {
                this.Longueur = mesure2;
                this.Largeur = mesure1;
            }
            Console.WriteLine("La fondation est finie!");
        }
    }
}
