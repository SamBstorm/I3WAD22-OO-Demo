using System;
using System.Collections.Generic;

namespace Demo_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture() { Couleur = "Rouge" };
            v1.Roule();

            Bateau b1 = new Bateau() { Couleur = "Bleu" };
            b1.Navigue();

            VoitureAmphibie va = new VoitureAmphibie() { Couleur = "Vert" };
            va.Roule();
            va.Navigue();

            List<INavigue> stock = new List<INavigue>();
            stock.Add(b1);
            stock.Add(va);

            INavigue voit_amph = stock[1];
            voit_amph.Navigue();
            ((VoitureAmphibie)voit_amph).Roule();
        }
    }
}
