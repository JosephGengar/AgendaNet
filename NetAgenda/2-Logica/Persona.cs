using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Logica
{
    public class Persona
    {
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


    }
}