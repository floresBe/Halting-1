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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonAgregarPieza_Click(object sender, EventArgs e)
        {
            AltadePiezas ventanaPiezas = new AltadePiezas();
            ventanaPiezas.Show();
        }

        private void buttonAgregarPrueba_Click(object sender, EventArgs e)
        {
            PruebasRealizadas ventanaPruebas = new PruebasRealizadas();
            ventanaPruebas.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ventanaInicio.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonPruebas_Click(object sender, EventArgs e)
        {
            Program.pruebaOdefecto = 2;
            PruebasDefectos ventanaPruebas = new PruebasDefectos();
            ventanaPruebas.Show();
        }

        private void buttonDefectos_Click(object sender, EventArgs e)
        {
            Program.pruebaOdefecto = 1;
            PruebasDefectos ventanaPruebas = new PruebasDefectos();
            ventanaPruebas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuReportes menu = new MenuReportes();
            menu.Show();
        }
    }
}
