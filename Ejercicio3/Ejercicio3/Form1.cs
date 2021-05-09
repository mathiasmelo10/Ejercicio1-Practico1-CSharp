using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbNombres.Items.Add(txtNombre.Text);
            lbApellidos.Items.Add(txtApellido.Text);
            lbTelefonos.Items.Add(txtTelefono.Text);
            lbDirecciones.Items.Add(txtDireccion.Text);

            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = lbNombres.SelectedIndex;

            lbNombres.Items.RemoveAt(indice);
            lbApellidos.Items.RemoveAt(indice);
            lbTelefonos.Items.RemoveAt(indice);
            lbDirecciones.Items.RemoveAt(indice);
        }
    }
}
