using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IDisposable
{
    class Transmission : IDisposable
    {
        private string _name;
        public Transmission(string name)
        {
            this._name = name;
            Console.WriteLine($"{this._name} : Roger!");
        }

        public void sendMessage(string message)
        {
            Console.WriteLine($"{this._name} : {message}");
        }

        public void Dispose()
        {
            Console.WriteLine($"{this._name} : Over!");
        }
    }
}
