using System;

namespace Demo_Event_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordonnee2D c2D = new Coordonnee2D(5, 5);
            c2D.ChangementCoordonnee += delegate (string fieldName, int newValue) { 
                Console.WriteLine($"{fieldName} => {newValue}"); 
            };

            c2D.X = 6;
            c2D.Y = 3;

            Coordonnee3D c3D = new Coordonnee3D(5, 5, 5);

            c3D.ChangementCoordonnee += delegate (string fieldName, int newValue) {
                Console.WriteLine($"{fieldName} => {newValue}");
            };

            c3D.X = 6;
            c3D.Y = 3;
            c3D.Z = 0;
        }
    }
}
