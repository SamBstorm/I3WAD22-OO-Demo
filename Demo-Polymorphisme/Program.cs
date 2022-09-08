using System;

namespace Demo_Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilitaire u1 = new Utilitaire
            {
                Marque = "Renault",
                Immatriculation = "1-BEL-123",
                Couleur = "Blanc",
                Moteur = "Essence",
                capaciteCoffre = 45
            };

            Utilitaire u2 = new Utilitaire
            {
                Marque = "Ford",
                Immatriculation = "1-BEL-124",
                Couleur = "Blanc",
                Moteur = "Diesel",
                capaciteCoffre = 60
            };

            Utilitaire u3 = new Utilitaire
            {
                Marque = "Ford",
                Immatriculation = "1-BEL-125",
                Couleur = "Bleu",
                Moteur = "Hybrid",
                capaciteCoffre = 120
            };

            Familial f1 = new Familial
            {
                Marque = "VolskWagen",
                Immatriculation = "1-FAM-001",
                Couleur = "Noir",
                Moteur = "Electrique",
                nombreSieges = 4
            };

            Familial f2 = new Familial
            {
                Marque = "VolskWagen",
                Immatriculation = "1-FAM-002",
                Couleur = "Orange",
                Moteur = "Electrique",
                nombreSieges = 6
            };

            Familial f3 = new Familial
            {
                Marque = "Mustang",
                Immatriculation = "1-FAM-003",
                Couleur = "Rouge",
                Moteur = "Diesel",
                nombreSieges = 3
            };

            Agence RentACar = new Agence
            {
                Nom = "Rent a car",
                Ville = "Bruxelles"
            };

            RentACar.Recuperer(u1);
            RentACar.Recuperer(u2);
            RentACar.Recuperer(u3);
            RentACar.Recuperer(f1);
            RentACar.Recuperer(f2);
            RentACar.Recuperer(f3);

            int nbJours = 7;
            decimal PrixLocation = RentACar.Louer("1-FAM-003", nbJours, out Vehicule maLocation);

            Console.WriteLine($"Pour louer la {maLocation.Marque} {maLocation.Couleur}, durant {nbJours} jours, vous devrez payer la somme de {PrixLocation}€.");

            maLocation.OuvrirCoffre();

            Vehicule v1 = new Utilitaire { 
                Marque="Audi",
                Moteur="Diesel",
                Immatriculation = "1-VEH-123",
                Couleur = "Gris",
                capaciteCoffre = 75
            };

            v1.OuvrirCoffre();
            Console.WriteLine($"Dans mon utilitaire, la capacité du coffre est de {((Familial)v1).nombreSieges} Littres.");
        }
    }
}
