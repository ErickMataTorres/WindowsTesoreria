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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Ventanas.GuardarUsuario ventana = new Ventanas.GuardarUsuario();
            ventana.Nuevo();
            if (ventana.DialogResult == DialogResult.Yes)
            {
                Usuario_Load(sender, e);
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            CargarDgvUsuario();
        }
        public void CargarDgvUsuario()
        {
            dgvUsuario.DataSource = Clases.Usuario.DataUsuario();
            dgvUsuario.AutoResizeColumns();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Ventanas.GuardarUsuario ventana = new Ventanas.GuardarUsuario();
            Clases.Usuario u = new Clases.Usuario();
            u.Id = int.Parse(dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["Id"].Value.ToString());
            u.Nombre = dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["Nombre"].Value.ToString();
            u.Telefono = dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["Telefono"].Value.ToString();
            u.Direccion = dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["Direccion"].Value.ToString();
            ventana.Modificar(u);
            if (ventana.DialogResult == DialogResult.Yes)
            {
                Usuario_Load(sender, e);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Realmente borrar el Usuario?\n"+dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["Nombre"].Value.ToString(), "Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Clases.Usuario u = new Clases.Usuario();
                string respuesta = u.BorrarUsuario(int.Parse(dgvUsuario.Rows[dgvUsuario.CurrentRow.Index].Cells["Id"].Value.ToString()));
                if ( respuesta== "Ok")
                {
                    Usuario_Load(sender, e);
                    MessageBox.Show("Se ha borrado correctamente", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show(respuesta, "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
