using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Logica
{
    public class GrupoContacto
    {
        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private List<Contacto> _contactos;

        public List<Contacto> contactos
        {
            get { return _contactos; }
            set { _contactos = value; }
        }


    }
}