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
    public partial class GuardarOfrendaMatutina : Form
    {
        public GuardarOfrendaMatutina()
        {
            InitializeComponent();
        }
        public void Nuevo()
        {
            txtId.Text = "Nuevo";
            this.ShowDialog();
        }

        private void GuardarOfrendaMatutina_Load(object sender, EventArgs e)
        {
            cbUsuarios.DataSource = Clases.Usuario.ComboBoxUsuario();
            cbUsuarios.ValueMember = "Id";
            cbUsuarios.DisplayMember = "Nombre";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Tesoreria clase = new Clases.Tesoreria();
            if (txtId.Text == "Nuevo")
            {
                clase.Id = -1;
            }
            else
            {
                clase.Id = int.Parse(txtId.Text);
            }
            clase.Descripcion = txtDescripcion.Text.Trim().ToUpper();
            clase.Cantidad = decimal.Parse(txtDinero.Text);
            clase.FechaAhorrado = dtpFechaAhorrado.Value;
            clase.FechaModificado = dtpFechaModificado.Value;
            clase.Concepto = cbConcepto.Text.ToUpper();
            clase.Usuario =int.Parse(cbUsuarios.SelectedValue.ToString());
            if (clase.GuardarOfrendaMatutina() == "Ok")
            {
                MessageBox.Show("Se ha guardado correctamente", "Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show(clase.GuardarOfrendaMatutina());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
