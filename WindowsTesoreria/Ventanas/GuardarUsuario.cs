using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTesoreria.Ventanas
{
    public partial class GuardarUsuario : Form
    {
        public GuardarUsuario()
        {
            InitializeComponent();
        }
        public void Nuevo()
        {
            txtId.Text = Clases.Usuario.SiguienteUsuario().ToString();
            this.ShowDialog();
        }
        public void Modificar(Clases.Usuario u)
        {
            txtId.Text = u.Id.ToString();
            txtNombre.Text = u.Nombre;
            txtTelefono.Text = u.Telefono;
            txtDireccion.Text = u.Direccion;
            this.ShowDialog();
        }

        private void GuardarUsuario_Load(object sender, EventArgs e)
        {

        }
        public void SiguienteUsuario()
        {
            txtId.Text = Clases.Usuario.SiguienteUsuario().ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Usuario u = new Clases.Usuario();
            u.Id = int.Parse(txtId.Text);
            u.Nombre = txtNombre.Text.ToUpper().Trim();
            u.Telefono = txtTelefono.Text.Trim();
            u.Direccion = txtDireccion.Text.ToUpper().Trim();
            if (u.GuardarUsuario() == "Ok")
            {
                MessageBox.Show("Se ha guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show(u.GuardarUsuario());
            }
        }
    }
}
