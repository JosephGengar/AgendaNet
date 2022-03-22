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
            if (txtNombre.Text != "" | txtApellido.Text != "")
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
            else
            {
                MessageBox.Show("Complete los campos, por favor!");
            }
           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Contacto oContacto = new Contacto();
            dgvGrillaDeContactos.DataSource = oContacto.ListarTabla();

            cmbListar.DataSource = oContacto.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbListar.DisplayMember = "apellido"; 
            //cmbListar.ValueMember = "codigo"; comento sino no funciona obviamente el override al tostring()
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            //int idSeleccionado =  (int)cmbListar.SelectedValue;
            //MessageBox.Show("el valor seleccionado es: " + idSeleccionado);
            //como mencione tengo mas plasticidad con objeto q con datatable
            Contacto oContacto = (Contacto)cmbListar.SelectedItem;
            MessageBox.Show("El codigo es: " + oContacto.codigo + " cuyo nombre y apellido es: " + oContacto.nombre + " " + oContacto.apellido);
        
        }
    }
}
