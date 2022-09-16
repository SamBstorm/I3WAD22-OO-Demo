using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Carwash
{
    class CarWashConsole
    {
        public void AfficheMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void EmettreSon(string message)
        {
            Console.Beep(3000, 100);
        }
    }
}
