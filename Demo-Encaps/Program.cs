using Demo_Encaps.Security;
using System;

namespace Demo_Encaps
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.login = "SamBstorm";
            user.SetPassword("Test1234=");

            string login;
            string password;
            int tries = 3;
            do
            {
                Console.WriteLine("Veuillez indiquer votre login :");
                login = Console.ReadLine();

                Console.WriteLine("Veuillez indiquer votre mot de passe :");
                password = Console.ReadLine();
                tries--;
                
            } while (!user.CheckUser(login, password)&& tries!=0);

            if (user.CheckUser(login, password)) Console.WriteLine($"Bienvenu {user.login}!");
            else Console.WriteLine("Trop d'essais...");
        }
    }
}
