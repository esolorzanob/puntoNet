using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerC
{
    class Prueba
    {
        private string _nombre;
        public string Nombre {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        

        public Prueba(string nombre) {
            _nombre = nombre;
            
        }


    }
}
