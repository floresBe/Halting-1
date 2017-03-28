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
    public partial class reportePruebas : Form
    {
        public reportePruebas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToString();
            string noSerie = comboBoxSerie.SelectedItem.ToString();
            string prueba = comboBoxPrueba.SelectedItem.ToString() ;
            string aprobo = "1era Aprobo.";
            string noHoney = textBoxHoney.Text;
            string observaciones = textBoxObservaciones.Text;
            string operador = "admin1";

            MessageBox.Show("Informacion a exportar: fecha: " + fecha + " Serie: " + noSerie + " Prueba: " + prueba + " Aprobo: " + aprobo + " noHoneyWell: " + noHoney + " Observaciones: " + observaciones + " Operador: " + operador);

        }
    }
}
