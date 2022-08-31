using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Heritage
{
    class Animal : EtreVivant
    {
        public string Allimentation { get; set; }
        public bool EstDomestique { get; set; }

        public virtual void SePresenter()
        {
            Console.WriteLine($"Bonjour je suis {Nom}!");
        }
    }
}
