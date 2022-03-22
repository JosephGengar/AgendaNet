using _2_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                Contacto oContacto = new Contacto();
                oContacto.nombre = txtNombre.Text;
                oContacto.apellido = txtApellido.Text;
                if (oContacto.Guardar())
                {
                    MessageBox.Show("El Contacto se agrego con exito!!");
                }
                else
                {
                    MessageBox.Show("No se ha podido Guardar el contacto");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
