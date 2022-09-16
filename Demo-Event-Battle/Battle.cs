using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Battle
{
    class Battle
    {
        public Player Left { get; private set; }
        public Player Rigth { get; private set; }

        public Battle(Player left, Player right)
        {
            Left = left;
            Rigth = right;
            Left.IsDead += PlayerActions.DeadAction;
            Rigth.IsDead += PlayerActions.DeadAction;
            Left.IsDead += delegate (object sender, string message)
            {
                Left.IsHurt -= PlayerActions.HurtAction; 
                Left.IsAttacking -= PlayerActions.AttackingAction;
            };


            Rigth.IsDead += delegate (object sender, string message)
            {
                Rigth.IsHurt -= PlayerActions.HurtAction;
                Rigth.IsAttacking -= PlayerActions.AttackingAction;
            };

            Left.IsHurt += PlayerActions.HurtAction;
            Rigth.IsHurt += PlayerActions.HurtAction;

            Left.IsAttacking += PlayerActions.AttackingAction;
            Rigth.IsAttacking += PlayerActions.AttackingAction;

        }

        public void Start()
        {
            while(Left.PointDeVie > 0 && Rigth.PointDeVie > 0)
            {
                Left.Frapper(Rigth);
                if(Rigth.PointDeVie >0){
                    Rigth.Frapper(Left);
                }
            }
        }
    }
}
