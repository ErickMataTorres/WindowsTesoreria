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
    public partial class OfrendaMatutina : Form
    {
        public OfrendaMatutina()
        {
            InitializeComponent();
        }

        private void OfrendaMatutina_Load(object sender, EventArgs e)
        {
            dgvEntradas.DataSource = Clases.Tesoreria.DataMatutino("ENTRADA");
            dgvSalidas.DataSource = Clases.Tesoreria.DataMatutino("SALIDA");

            txtTotalEntradas.Text = Clases.Tesoreria.TotalesMatutino("ENTRADA").ToString();
            txtTotalSalidas.Text = Clases.Tesoreria.TotalesMatutino("SALIDA").ToString();

            txtTotal.Text = (decimal.Parse(txtTotalEntradas.Text) - decimal.Parse(txtTotalSalidas.Text)).ToString();

            txtTabTotalEntradas.Text = Clases.Tesoreria.TabTotalMatutina("ENTRADA").ToString();
            txtTabTotalSalidas.Text = Clases.Tesoreria.TabTotalMatutina("SALIDA").ToString();


        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            GuardarOfrendaMatutina ventana = new GuardarOfrendaMatutina();
            ventana.Nuevo();
            if (ventana.DialogResult == DialogResult.Yes)
            {
                OfrendaMatutina_Load(sender, e);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
