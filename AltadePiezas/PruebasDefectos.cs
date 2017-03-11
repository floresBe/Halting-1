using Servicio;
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
    public partial class PruebasDefectos : Form
    {
        string nombre;
        string descripcion;
        cDefecto defecto = new cDefecto();
        cPrueba prueba = new cPrueba();

        public PruebasDefectos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != string.Empty)
            {
                nombre = textBoxNombre.Text;
            }else
            {
                MessageBox.Show("Escribir nombre.");
                textBoxNombre.Focus();
                return;
            }
            if (textBoxDescripcion.Text != string.Empty)
            {
                descripcion = textBoxDescripcion.Text;
            }
            else
            {
                MessageBox.Show("Agregar una breve descripcion.");
                textBoxDescripcion.Focus();
                return;
            }

            if (Program.pruebaOdefecto == 1)
            {
                var respuesta = MessageBox.Show("Seguro que desea agregar el defecto a la base de datos?", "Agregar defecto", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    defecto.Insertar(nombre, descripcion);
                }
            }
            else if (Program.pruebaOdefecto == 2)
            {
                var respuesta = MessageBox.Show("Seguro que desea agregar la prueba a la base de datos?", "Agregar prueba", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    prueba.Insertar(nombre, descripcion);
                }
            }



        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            int largoCadena = textBoxDescripcion.Text.Length;
            if(largoCadena < 26)
            {
                int restantes = 25 - largoCadena;
                labelCaracteres.Text = restantes + " caracteres restantes.";
            }
            else
            {
                textBoxDescripcion.Text = textBoxDescripcion.Text.Remove(25);
            }
        }

        private void PruebasDefectos_Load(object sender, EventArgs e)
        {
            if (Program.pruebaOdefecto == 1)
            {
                labelTitulo.Text = "Defecto";
            }
            else if (Program.pruebaOdefecto == 2)
            {
                labelTitulo.Text = "Prueba";
            }
        }
    }
}
