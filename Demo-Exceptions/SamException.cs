using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exceptions
{
    class SamException : Exception
    {
        private string _name;
        public string NomVariableQuiContientSam {
            get { return _name; }
        }

        public SamException(string nomVariable, string message) : base(message)
        {
            _name = nomVariable;
        }
    }
}
