using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Battle
{
    static class PlayerActions
    {
        public static void DeadAction(object sender, string message)
        {
            Console.WriteLine($"{((Player)sender).Name} {message}");
        }

        public static void HurtAction(object sender, int damage)
        {
            Console.WriteLine($"{((Player)sender).Name} s'est blessé ({damage} dégats)");
        }

        public static void AttackingAction(object sender, Player opponent, int damage)
        {
            Console.WriteLine($"{((Player)sender).Name} attaque violament {opponent.Name}!");
            opponent.SeBlesser(damage);
        }
    }
}
