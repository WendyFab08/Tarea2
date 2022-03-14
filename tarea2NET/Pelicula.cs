using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2NET
{
    internal class Pelicula
    {
        private string _titulo;
        private string _genero;
        private string _nacionalidad;
        private string _aEstreno;
        

        public Pelicula(string titulo, string genero, string nacionalidad, int aEstreno)
        {
            this._aEstreno=aEstreno;
            this._genero=genero;
            this._nacionalidad=genero;
            this._titulo=titulo;
        }

        public string aEstreno
        {
            get { return _aEstreno; }
            set { _aEstreno = value; }
        }


        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }


        public string nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }

        public string titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public override string ToString()
        {
            return $"Titulo: {_titulo}, Genero: {_genero}, Nacionalidad: {_nacionalidad}, Año de estreno: {_aEstreno}";
        }
    }
}