using System;

namespace Demo_Event_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player("Scorpion");
            Player p2 = new Player("Sub-Zero");

            Console.WriteLine("MORTAL KOMBAT!");

            Battle b = new Battle(p1, p2);

            b.Start();


        }
    }
}
