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
    public partial class OfrendaVespertino : Form
    {
        public OfrendaVespertino()
        {
            InitializeComponent();
        }

        private void OfrendaVespertino_Load(object sender, EventArgs e)
        {
            dgvEntradas.DataSource = Clases.Tesoreria.DataVespertino("ENTRADA");
            dgvSalidas.DataSource = Clases.Tesoreria.DataVespertino("SALIDA");
            txtTotalEntradas.Text = Clases.Tesoreria.TotalesVespertina("ENTRADA").ToString();
            txtTotalSalidas.Text = Clases.Tesoreria.TotalesVespertina("SALIDA").ToString();

            txtTotal.Text = (decimal.Parse(txtTotalEntradas.Text) - decimal.Parse(txtTotalSalidas.Text)).ToString();
            txtTabTotalEntradas.Text = Clases.Tesoreria.TabTotalVespertina("ENTRADA").ToString();
            txtTabTotalSalidas.Text = Clases.Tesoreria.TabTotalVespertina("SALIDA").ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GuardarOfrendaVespertina ventana = new GuardarOfrendaVespertina();
            ventana.Nuevo();
            if (ventana.DialogResult == DialogResult.Yes)
            {
                OfrendaVespertino_Load(sender, e);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
