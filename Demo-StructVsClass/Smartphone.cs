using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_StructVsClass
{
    class SmartphoneClass
    {
        public string marque;
        public string modele;
        public string serialNumber;
        public int pixelHeight;
        public int pixelWidth;
    }

    struct SmartphoneStruct
    {
        public string marque;
        public string modele;
        public string serialNumber;
        public int pixelHeight;
        public int pixelWidth;
    }
}
