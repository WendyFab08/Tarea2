using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    internal class Autor
    {

        private String _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
 
        

        public Autor(string nombre)
        {
            this._nombre = nombre;
        }

        public override string ToString()
        {
            return  nombre: {_nombre}";
        }
    }
}
