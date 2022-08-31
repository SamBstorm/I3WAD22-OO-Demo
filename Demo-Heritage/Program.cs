using System;

namespace Demo_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dinosaure = new Animal();
            dinosaure.Nom = "Rexy";

            Oiseau canari = new Oiseau();
            canari.Nom = "Titi";
            canari.Couleur = "Jaune";
            canari.EstDomestique = true;
            canari.DateNaissance = new DateTime(1942, 1, 1);
            canari.Allimentation = "Graines et Ver de terre";
            canari.LongueurBec = 13.5;
            canari.TaillePlumage = 45;
            canari.SePresenter();
            canari.Voler();

            Poisson clown = new Poisson();
            clown.Nom = "Némo";
            clown.Couleur = "Orange";
            clown.EstDomestique = false;
            clown.DateNaissance = new DateTime(2001, 01, 01);
            clown.Allimentation = "Plancton";
            clown.EstDEauDouce = false;
            clown.Longueur = 32;
            clown.SePresenter();
            clown.Nager();
        }
    }
}
