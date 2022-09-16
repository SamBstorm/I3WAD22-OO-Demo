using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Heritage
{
    delegate void CoodonneeChangeHandler(string fieldName, int newValue);
    class Coordonnee2D
    {
        public event CoodonneeChangeHandler ChangementCoordonnee;
        private int _x;
        public int X { 
            get { return _x; }
            set {
                if (X != value)
                    ActiveChangementCoordonnee(nameof(X), value);
                _x = value; }
        }

        private int _y;
        public int Y
        {
            get { return _y; }
            set {
                if (Y != value)
                    ActiveChangementCoordonnee(nameof(Y), value);
                _y = value; }
        }

        public Coordonnee2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        protected void ActiveChangementCoordonnee (string fieldName, int newValue)
        {
            this.ChangementCoordonnee?.Invoke(fieldName, newValue);
        }
    }
}
