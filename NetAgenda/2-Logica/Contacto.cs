using _3_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace _2_Logica
{
    public class Contacto : Persona
    {
        private int _codigo;

        public int codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

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

        public DataTable ListarTabla()
        {
            //lo utiliz0 como muestra en el datagridview
            ContactoBD oContacto = new ContactoBD();
            return oContacto.listar();
        }
        public List<Contacto> Listar()
        {
            //como voy a tener coleccion d contactos lo utilizo en el combobox para tener mas plasticidad
            List<Contacto> ListaRetorno = new List<Contacto>();
            Contacto oContacto;
            foreach (DataRow item in ListarTabla().Rows)
            {
                oContacto = new Contacto();
                oContacto.nombre = item[1].ToString();
                oContacto.apellido = item["apellido"].ToString();
                oContacto.codigo = int.Parse(item[0].ToString());

                ListaRetorno.Add(oContacto);
            }

            return ListaRetorno;
        }

        public override string ToString()
        {
            //return base.ToString();
            //en lugar de informar al display member, como quiero mas datos sobrescribo el tostring()
            return string.Format("{0} - {1}, {2}", this.codigo, this.apellido, this.nombre);
        }
    }
}