using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    class Bateau : Vehicule, INavigue
    {
        public void Navigue()
        {
            Console.WriteLine("Flote, flote...");
        }
    }
}
