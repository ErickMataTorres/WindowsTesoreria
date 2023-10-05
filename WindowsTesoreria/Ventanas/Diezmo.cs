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
    public partial class Diezmo : Form
    {
        public Diezmo()
        {
            InitializeComponent();
        }

        private void Diezmo_Load(object sender, EventArgs e)
        {
            dgvEntradas.DataSource = Clases.Tesoreria.DataDiezmo("ENTRADA");
            dgvSalidas.DataSource = Clases.Tesoreria.DataDiezmo("SALIDA");
            txtTotalEntradas.Text = Clases.Tesoreria.TotalesDiezmo("ENTRADA").ToString();
            txtTotalSalidas.Text = Clases.Tesoreria.TotalesDiezmo("SALIDA").ToString();

            txtTotal.Text = (decimal.Parse(txtTotalEntradas.Text) - decimal.Parse(txtTotalSalidas.Text)).ToString();
            txtTabTotalEntradas.Text = Clases.Tesoreria.TabTotalDiezmo("ENTRADA").ToString();
            txtTabTotalSalidas.Text = Clases.Tesoreria.TabTotalDiezmo("SALIDA").ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GuardarDiezmo ventana = new GuardarDiezmo();
            ventana.Nuevo();
            if (ventana.DialogResult == DialogResult.Yes)
            {
                Diezmo_Load(sender, e);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
