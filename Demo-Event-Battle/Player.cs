using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Battle
{
    delegate void DeadActionHandler(object sender, string message);
    delegate void HurtActionHandler(object sender, int damage);
    delegate void AttackActionHandler(object sender, Player opponent, int damage);
    class Player
    {
        public event DeadActionHandler IsDead;
        public event HurtActionHandler IsHurt;
        public event AttackActionHandler IsAttacking;

        private Random RNG;
        private int _pointDeVie;
        public int PointDeVie { 
            get { return _pointDeVie; }
            set {
                if (value <= 0)
                {
                    IsDead?.Invoke(this, "est mort!");
                    _pointDeVie = 0;
                }
                else
                {
                    _pointDeVie = value;
                }
            }
        }

        public string Name { get; private set; }
        public Player(string name)
        {
            RNG = new Random();
            PointDeVie = 10;
            Name = name;
        }

        public void Frapper(Player adversaire)
        {
            int degat = RNG.Next(0, 4);
            IsAttacking?.Invoke(this, adversaire, degat);
        }

        public void SeBlesser(int degat)
        {
            this.PointDeVie -= degat;
            IsHurt?.Invoke(this, degat);
        }
    }
}
