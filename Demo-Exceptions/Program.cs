using System;

namespace Demo_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division();
            try
            {
                DemanderString("Veuillez vous identifier :");
            }
            catch (SamException e)
            {
                AfficheErreur(e.NomVariableQuiContientSam);
            }
        }

        static void AfficheErreur(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Division()
        {
            try
            {
                Console.WriteLine("Veuillez indiquer un nombre à diviser :");
                int nb1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Veuillez indiquer le diviseur :");
                int nb2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Division(nb1,nb2));
            }
            catch (ArgumentException ex)
            {
                //Console.WriteLine($"Type : {ex.GetType()}");
                //Console.WriteLine($"Message : {ex.Message}");
                AfficheErreur(ex.Message);
                Division();
            }
            catch (FormatException ex)
            {
                AfficheErreur($"Mauvais format d'information : {ex.Message}.");
                Division();
            }
        }

        static int Division(int nb1, int nb2)
        {
            if (nb2 == 0) throw new ArgumentException($"On ne peut pas diviser par 0... nb2 vaut : {nb2}");
            return nb1 / nb2;
        }

        static string DemanderString(string message) {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            try
            {
                if (result == "Sam") throw new SamException(nameof(result),"Erreur dans la méthode DemanderString");
            }
            catch (SamException ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
