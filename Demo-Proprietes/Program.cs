using System;

namespace Demo_Proprietes
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit figues = new Produit();
            figues.Price = 9.99M;
            figues.Promo = 25;
            Console.WriteLine($"Le prix des figues est : {figues.Price} €... "); // avec une promo de : {figues.Promo}");
        }
    }
}
