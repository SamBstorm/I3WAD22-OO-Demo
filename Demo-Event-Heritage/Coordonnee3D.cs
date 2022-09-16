using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Heritage
{
    class Coordonnee3D : Coordonnee2D
    {
        private int _z;
        public int Z {
            get { return _z; }
            set {
                if (Z != value)
                    ActiveChangementCoordonnee(nameof(Z), value);
                _z = value; }
        }
        public Coordonnee3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
}
