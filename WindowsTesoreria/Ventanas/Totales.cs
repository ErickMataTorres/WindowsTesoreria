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
    public partial class Totales : Form
    {
        public Totales()
        {
            InitializeComponent();
        }

        private void Totales_Load(object sender, EventArgs e)
        {
            txtTotalEntradasMatutinas.Text = Clases.Tesoreria.TotalesMatutino("ENTRADA").ToString();
            txtTotalSalidasMatutinas.Text = Clases.Tesoreria.TotalesMatutino("SALIDA").ToString();
            txtTotalMatutina.Text = (decimal.Parse(txtTotalEntradasMatutinas.Text) - decimal.Parse(txtTotalSalidasMatutinas.Text)).ToString();

            txtTotalEntradasVespertinas.Text = Clases.Tesoreria.TotalesVespertina("ENTRADA").ToString();
            txtTotalSalidasVespertinas.Text = Clases.Tesoreria.TotalesVespertina("SALIDA").ToString();
            txtTotalVespertina.Text = (decimal.Parse(txtTotalEntradasVespertinas.Text) - decimal.Parse(txtTotalSalidasVespertinas.Text)).ToString();

            txtTotalEntradasDiezmos.Text = Clases.Tesoreria.TotalesDiezmo("ENTRADA").ToString();
            txtTotalSalidasDiezmos.Text = Clases.Tesoreria.TotalesDiezmo("SALIDA").ToString();
            txtTotalDiezmos.Text = (decimal.Parse(txtTotalEntradasDiezmos.Text) - decimal.Parse(txtTotalSalidasDiezmos.Text)).ToString();

            txtTotal.Text = (decimal.Parse(txtTotalMatutina.Text) + decimal.Parse(txtTotalVespertina.Text) + decimal.Parse(txtTotalDiezmos.Text)).ToString();


        }
    }
}
