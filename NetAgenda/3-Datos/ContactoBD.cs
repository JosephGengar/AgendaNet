using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Datos
{
    public class ContactoBD
    {
        public bool Agregarcontacto(string nombre, string apellido)
        {
            Conexion oConexion = new Conexion();
            string insertQuery = "INSERT INTO tContacto(nombre, apellido) values( '" + nombre + "', '" + apellido + "')";
            int filasAfectadas = oConexion.EscribirPorComando(insertQuery);
            if (filasAfectadas>0)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }
        public DataTable listar()
        {
            Conexion oConexion = new Conexion();
            string query = "SELECT * FROM tContacto";
            return oConexion.LeerPorComando(query);
        }
    }
}
