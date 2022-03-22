using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Logica
{
    public class Agenda
    {
        private List<Contacto> _contactos;

        public List<Contacto> contactos
        {
            get { return _contactos; }
            set { _contactos = value; }
        }
        private List<GrupoContacto> _grupos;

        public List<GrupoContacto> grupos
        {
            get { return _grupos; }
            set { _grupos = value; }
        }

    }
}