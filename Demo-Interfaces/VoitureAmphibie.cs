using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    class VoitureAmphibie : Vehicule, INavigue, IRoule
    {
        public void Navigue()
        {
            Console.WriteLine("Plouf, plouf...");
        }

        public void Roule()
        {
            Console.WriteLine("Tut, tut!"); ;
        }
    }
}
