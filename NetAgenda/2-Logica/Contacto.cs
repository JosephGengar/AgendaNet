using _3_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Logica
{
    public class Contacto : Persona
    {
        private List<string> _numerosDeContacto;

        public List<string> numerosDeContacto
        {
            get { return _numerosDeContacto; }
            set { _numerosDeContacto = value; }
        }
        public bool Guardar()
        {
            ContactoBD oContactoBD = new ContactoBD();
            return oContactoBD.Agregarcontacto(this.nombre, this.apellido);
        }

    }
}