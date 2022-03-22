using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Logica
{
    public class Agenda
    {
        public Agenda()
        {
            contactos = new List<Contacto>();
            grupos = new List<GrupoContacto>();
        }
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

        public void CrearContacto(string nombre, string apellido)
        {
            Contacto oContacto = new Contacto();
            oContacto.nombre = nombre;
            oContacto.apellido = apellido;
            oContacto.Guardar();
            this.contactos.Add(oContacto);
        }

    }
}