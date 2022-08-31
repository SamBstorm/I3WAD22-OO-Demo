using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage
{
    class Poisson : Animal
    {
        public bool EstDEauDouce { get; set; }
        public double Longueur { get; set; }
        public void Nager() {
            Console.WriteLine($"Je nage!");
        }

        public override void SePresenter()
        {
            base.SePresenter();
            Console.WriteLine($"Je suis un poisson ! Bloup bloup!");
        }
    }
}
