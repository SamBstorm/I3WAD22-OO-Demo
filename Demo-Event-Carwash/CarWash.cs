using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Event_Carwash
{
    delegate void CarWashAction(Voiture v);
    delegate void ChangeActionHandler(string message);
    class CarWash
    {
        private CarWashAction _cycleLavage;
        public event ChangeActionHandler changeAction = null;

        public CarWash()
        {
            _cycleLavage = delegate (Voiture v) {  changeAction?.Invoke($"Je prépare la voiture : {v.Plaque}"); };
            _cycleLavage += delegate (Voiture v) { changeAction?.Invoke($"Je lave la voiture : {v.Plaque}"); };
            _cycleLavage += delegate (Voiture v) { changeAction?.Invoke($"Je sèche la voiture : {v.Plaque}"); };
            _cycleLavage += delegate (Voiture v) { changeAction?.Invoke($"Je finalise la voiture : {v.Plaque}"); };
        }

        public void Traiter(Voiture v)
        {
            _cycleLavage?.Invoke(v);
        }
    }
}
