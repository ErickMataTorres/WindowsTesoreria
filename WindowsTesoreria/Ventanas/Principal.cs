using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTesoreria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOfrendaMatutina_Click(object sender, EventArgs e)
        {
            Ventanas.OfrendaMatutina ventana = new Ventanas.OfrendaMatutina();
            ventana.ShowDialog();
        }

        private void BtnDiezmo_Click(object sender, EventArgs e)
        {
            Ventanas.Diezmo ventana = new Ventanas.Diezmo();
            ventana.ShowDialog();
        }

        private void BtnOfrendaVespertina_Click(object sender, EventArgs e)
        {
            Ventanas.OfrendaVespertino ventana = new Ventanas.OfrendaVespertino();
            ventana.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            Ventanas.Usuario ventana = new Ventanas.Usuario();
            ventana.ShowDialog();
            
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            Ventanas.Totales ventana = new Ventanas.Totales();
            ventana.ShowDialog();
        }
    }
}
