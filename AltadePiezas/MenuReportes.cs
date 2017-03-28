using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltadePiezas
{
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void buttonPruebas_Click(object sender, EventArgs e)
        {
            reporteCiclo reporte = new reporteCiclo();
            reporte.Show();
        }

        private void buttonDefectos_Click(object sender, EventArgs e)
        {
            reportePruebas reporte = new reportePruebas();
            reporte.Show();
        }
    }
}
